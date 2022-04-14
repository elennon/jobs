using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp5
{
    public class Drawers
    {
        public int baseWidth = 0;
        public int sideHeight = 0;
        public int kicker = 0;
        public int lowSideHeight = 0;
        public int flatTopWidth = 0;
        public double cuttingAngle = 0;
        public int drawerNumber = 3;
        public int depth;
        public int drawerSectionWidth;
        public drawerSectionUnit drawerSectionUnit = new drawerSectionUnit();
        public int tallUnitWidth;
        public int bottomCornerOfAngle;
        public int plumbLineThroughTopDRawerFrame;
        public bool hasTallUnit;
        public double eighteenMdfArea = 0;
        public double twelveMdfArea = 0;

        public Drawers(int baseWidthP, int sideHeightP, int kickerP, int lowSideHeightP,
            int flatTopWidthP, double angleP, int drawerNumberP,
            int depthP, int tallUnitWidthP, bool hasTallUnitP)
        {
            baseWidth = baseWidthP;
            sideHeight = sideHeightP;
            kicker = kickerP;
            lowSideHeight = lowSideHeightP;
            flatTopWidth = flatTopWidthP;
            cuttingAngle = angleP;
            drawerNumber = drawerNumberP;
            depth = depthP;
            tallUnitWidth = tallUnitWidthP;
            hasTallUnit = hasTallUnitP;
        }

        public void getCuttingList(Drawers understairDrawerUnit)
        {
            var cutList = new List<cut>();
            var origlowside = understairDrawerUnit.lowSideHeight;
            bottomCornerOfAngle = getBottomCornerTipExtraBit(understairDrawerUnit);
            checkAngle(understairDrawerUnit, origlowside);
            cutList.AddRange(getDrawerFrame(understairDrawerUnit.baseWidth,
                understairDrawerUnit.cuttingAngle, understairDrawerUnit.tallUnitWidth,
                understairDrawerUnit.lowSideHeight, understairDrawerUnit.drawerNumber
                ));
            
            cutList.AddRange(GetDrawers(understairDrawerUnit));
            if(understairDrawerUnit.hasTallUnit) cutList.AddRange(GetTallUnit(understairDrawerUnit));
            PrintOut(cutList);
            var noShts = (eighteenMdfArea + (eighteenMdfArea / 100 * 10)) / 2880000;
            int i = (int)Math.Ceiling(noShts);
            MessageBox.Show("done -- " + eighteenMdfArea.ToString());
        }

        private void checkAngle(Drawers understairDrawerUnit, int origlowside)
        {
            double a = Convert.ToDouble(understairDrawerUnit.baseWidth);
            double b = Convert.ToDouble(understairDrawerUnit.sideHeight - origlowside);
            double tangle = Math.Atan(a / 
                b) * (180 / Math.PI);
            if (understairDrawerUnit.cuttingAngle != tangle)
            {
                MessageBox.Show("given angle -- " + understairDrawerUnit.cuttingAngle + " -- calculated -- " + tangle);
            }
            understairDrawerUnit.cuttingAngle = tangle;
        }

        private IEnumerable<cut> GetTallUnit(Drawers understairDrawerUnit)
        {
            List<cut> tallUnit = new List<cut>();
            var plumbTallUnitTop = getHypot(understairDrawerUnit.cuttingAngle, 48);
            var shrt = getAdjasent(cuttingAngle, bottomCornerOfAngle + drawerSectionWidth + 32 +18);
            tallUnit.Add(new cut(700, shrt - (plumbTallUnitTop + 78), 1, false, "tall unit short side toLong"));
            eighteenMdfArea += 700 * shrt - (plumbTallUnitTop + 78);

            var lgs = getAdjasent(cuttingAngle, bottomCornerOfAngle + drawerSectionWidth + 32 + understairDrawerUnit.tallUnitWidth);
            tallUnit.Add(new cut(700, lgs - (plumbTallUnitTop + 78), 1, false, "tall unit short side toLong"));
            eighteenMdfArea += 700 * lgs - (plumbTallUnitTop + 78);
            tallUnit.Add(new cut(700, understairDrawerUnit.tallUnitWidth - 36, 1, false, "tall unit base ( 2 for shelf..)"));
            eighteenMdfArea += (700 * understairDrawerUnit.tallUnitWidth - 36) * 2;

            tallUnit.Add(new cut(700, getHypot(understairDrawerUnit.cuttingAngle, understairDrawerUnit.tallUnitWidth), 1, false, 
                "tall unit top long to short"));
            eighteenMdfArea += 700 * getHypot(understairDrawerUnit.cuttingAngle, understairDrawerUnit.tallUnitWidth);
            tallUnit.Add(new cut(lgs, understairDrawerUnit.tallUnitWidth, 1, false, "tall unit back 9mm"));
            if (understairDrawerUnit.tallUnitWidth > 600)
            {
                tallUnit.Add(new cut(lgs, (understairDrawerUnit.tallUnitWidth / 2) - 5, 2, false, "tall unit double door"));
                eighteenMdfArea += (lgs * (understairDrawerUnit.tallUnitWidth / 2) - 5) * 2;
            } else tallUnit.Add(new cut(lgs, understairDrawerUnit.tallUnitWidth - 3 , 1, false, "tall unit door")); eighteenMdfArea += lgs * understairDrawerUnit.tallUnitWidth - 3;

            return tallUnit;
        }

        private int getBottomCornerTipExtraBit(Drawers udu)
        {
            if (lowSideHeight < 223)
            {
                plumbLineThroughTopDRawerFrame = getHypot(udu.cuttingAngle, 62);   
                var f = getOpposite(udu.cuttingAngle, plumbLineThroughTopDRawerFrame + 120 + 78);
                udu.lowSideHeight = getAdjasent(udu.cuttingAngle, f - 62);
            }
            return getOpposite(udu.cuttingAngle, lowSideHeight);
        }

        private void PrintOut(List<cut> cutList)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Asus\Documents\tester.txt"))
            {
                foreach (cut line in cutList)
                {
                    file.WriteLine(line.title);
                    if (line.toLong)
                        file.WriteLine(line.length + " * " + line.width + " * " + line.numberOf + " long");
                    else
                        file.WriteLine(line.length + " * " + line.width + " * " + line.numberOf);
                }
            }
        }

        private IEnumerable<cut> GetDrawers(Drawers understairDrawerUnit)
        {
            List<cut> drawers = new List<cut>();
            int dpt, noOfBigSide, noOfSmallSide, baseNumber, middleSizeDrawers, normalDrawerSize;
            if (understairDrawerUnit.depth < 750) dpt = 700;
            else dpt = 750;
            if (understairDrawerUnit.drawerNumber == 3)
            {
                noOfBigSide = 4; noOfSmallSide = 2; baseNumber = 3; middleSizeDrawers = 4; normalDrawerSize = 2; 
            }
            else
            {
                noOfBigSide = 9; noOfSmallSide = 3; baseNumber = 6; middleSizeDrawers = 4; normalDrawerSize = 8; 
            }
            drawers.Add(new cut(230, dpt, noOfBigSide, false, "drawer long"));
            eighteenMdfArea += (230 * dpt) * noOfBigSide;
            drawers.Add(new cut(100, dpt, noOfSmallSide, false, "drawer lodg"));
            eighteenMdfArea += (100 * dpt) * noOfSmallSide;
            drawers.Add(new cut(230, drawerSectionUnit.opeOne - 63, normalDrawerSize, false, "drawer short"));
            eighteenMdfArea += (230 * drawerSectionUnit.opeOne - 63) * normalDrawerSize;
            drawers.Add(new cut(230, drawerSectionUnit.opeTwo - 63, middleSizeDrawers, false, "drawer short"));
            eighteenMdfArea += (230 * drawerSectionUnit.opeTwo - 63) * normalDrawerSize;
            drawers.Add(new cut(dpt, drawerSectionUnit.opeOne - 27, baseNumber, false, "drawer base 12mm"));
            twelveMdfArea += (dpt * drawerSectionUnit.opeOne - 27) * baseNumber;
            drawers.Add(new cut(drawerSectionUnit.drwHeight, drawerSectionUnit.opeOne + 30, baseNumber, false, "drawer fronts"));
            eighteenMdfArea += (drawerSectionUnit.drwHeight * drawerSectionUnit.opeOne + 30) * normalDrawerSize;
            return drawers;
        }

        private List<cut> getDrawerFrame(int baseWidth, double cuttingAngle, int cabinetWidth,
            int bottomUpstandHeight, int drawerNumber)
        {
            var drawerFrameCutList = new List<cut>();
            if (bottomUpstandHeight < 223)
            {
                bottomUpstandHeight = getAdjasent(cuttingAngle, bottomCornerOfAngle);
            }
            drawerSectionWidth = getDrawerSectionWidth(baseWidth, cabinetWidth, bottomUpstandHeight, cuttingAngle);
            
            if (drawerNumber == 6)
            {
                var drawerWit = drawerSectionWidth / 3;
                drawerSectionUnit.opeOne = drawerWit - 48;
                drawerSectionUnit.opeTwo = drawerWit - 32;
                drawerSectionUnit.opeThree = drawerWit - 48;
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeOne, 0, 0, false, "number 1 ope"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeTwo, 0, 0, false, "number 2 ope"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeThree, 0, 0, false, "number 3 ope"));

                var no3 = getAdjasent(cuttingAngle, bottomCornerOfAngle + drawerWit + 32 - (64 + drawerSectionUnit.opeThree 
                    + drawerSectionUnit.opeTwo));
                drawerFrameCutList.Add(new cut(no3 - (78 + plumbLineThroughTopDRawerFrame), 0, 2, true, "vertical to long"));
                
                drawerFrameCutList.Add(new cut(700, 0, 4, false, "700mm bottoms"));
                drawerFrameCutList.Add(new cut(562, 0, 5, false, "562 middles"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeThree, 0, 4, false, "cross peice"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeTwo, 0, 2, false, "cross peice"));
            }
            else
            {
                var drawerWit = drawerSectionWidth / 2;
                drawerSectionUnit.opeOne = drawerWit - 48;
                drawerSectionUnit.opeTwo = drawerWit - 48;
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeOne, 0, 0, false, "number 1 ope"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeTwo, 0, 0, false, "number 2 ope"));
                
                drawerFrameCutList.Add(new cut(700, 0, 3, false, "700mm bottoms"));
                drawerFrameCutList.Add(new cut(562, 0, 2, false, "562 middles"));
                drawerFrameCutList.Add(new cut(drawerSectionUnit.opeTwo, 0, 2, false, "cross peice"));
            }
            // longest vertical
            var longestY = getAdjasent(cuttingAngle, bottomCornerOfAngle + drawerSectionWidth + 32);            
            drawerFrameCutList.Add(new cut(longestY - (78 + plumbLineThroughTopDRawerFrame), 0, 2, true, "vertical to long"));
            drawerSectionUnit.drwHeight = (longestY - 80) / 2;
            var secondLongestV = getAdjasent(cuttingAngle, bottomCornerOfAngle + drawerSectionWidth + 32 - (32 + drawerSectionUnit.opeOne));
            drawerFrameCutList.Add(new cut(secondLongestV - (78 + plumbLineThroughTopDRawerFrame), 0, 2, true, "vertical to long"));

            var shortestV = getAdjasent(cuttingAngle, bottomCornerOfAngle + 64);
            drawerFrameCutList.Add(new cut(shortestV - (78 + plumbLineThroughTopDRawerFrame), 0, 2, true, "vertical to long"));
            drawerFrameCutList.Add(new cut(drawerSectionWidth, 540, 1, false, "base peice"));
            return drawerFrameCutList;
        }

        private int getDrawerSectionWidth(int fullWidth, int cabinetWidth, int bottomUpstandHeight, double cuttingAngle)
        {
            var dw = ((fullWidth - bottomCornerOfAngle) - cabinetWidth) - 70;
            if (bottomUpstandHeight < 198)
            {
                var fv = getOpposite(cuttingAngle, 198);
                dw -= fv;
            }
            return dw;
        }


        private int getHypot(double angle, int opposite)
        {
            return Convert.ToInt32(opposite / Math.Sin(angle * (Math.PI / 180)));
        }

        private int getAdjasent(double angle, int opposite)
        {
            return Convert.ToInt32(opposite / Math.Tan(angle * (Math.PI / 180)));
        }

        private int getOpposite(double angle, int adjasent)
        {
            return Convert.ToInt32(adjasent * Math.Tan(angle * (Math.PI / 180)));
        }

    }

    public class cut
    {
        public int length = 0;
        public int width = 0;
        public int numberOf = 0;
        public bool toLong;
        public string title;
        public string ope;

        public cut(int lengthP, int widthP, int numberOfP, bool toLongP, string titleP)
        {
            length = lengthP;
            width = widthP;
            numberOf = numberOfP;
            toLong = toLongP;
            title = titleP;
        }
    }

    public class drawerSectionUnit
    {
        public int vertical;
        public int bottom;
        public int middles;
        public int accrossOpe;
        public int baseBoard;
        public int top;
        public int opeOne;
        public int opeTwo;
        public int opeThree;
        public int drwHeight;
    }
}
