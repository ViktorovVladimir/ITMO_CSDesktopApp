using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;
using System.Numerics;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleCalculator
{
	/// <summary>
	/// Summary description for CalcUI.
	/// </summary>
	public class CalcUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox VersionInfo;
		private System.Windows.Forms.Button KeyExit;
		private System.Windows.Forms.Button KeyDate;
		private System.Windows.Forms.TextBox OutputDisplay;
		private System.Windows.Forms.Button KeyClear;
		private System.Windows.Forms.Button KeyMinus;
		private System.Windows.Forms.Button KeyPlus;
		private System.Windows.Forms.Button KeyEqual;
		private System.Windows.Forms.Button KeyMultiply;
		private System.Windows.Forms.Button KeyDivide;
		private System.Windows.Forms.Button KeyPoint;
		private System.Windows.Forms.Button KeySign;
		private System.Windows.Forms.Button KeyZero;
		private System.Windows.Forms.Button KeyNine;
		private System.Windows.Forms.Button KeyEight;
		private System.Windows.Forms.Button KeySeven;
		private System.Windows.Forms.Button KeySix;
		private System.Windows.Forms.Button KeyFive;
		private System.Windows.Forms.Button KeyFour;
		private System.Windows.Forms.Button KeyThree;
		private System.Windows.Forms.Button KeyTwo;
		private System.Windows.Forms.Button KeyOne;

        //--
        private ToolTip toolTip;



		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";
        private MenuStrip menuTopStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem extendedToolStripMenuItem;
        private ToolStripMenuItem standartToolStripMenuItem;
        private Button squareNumber;
        private Button reciprocalСalculation;
        private Button squareRoot;
        private Button exponentiation;
        private Button calcFactorial;
        private Button cubeRoot;
        private Button solvQuadraticEquation;
        private Button longOperation;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


		public CalcUI()
		{
			//
			// Required for Windows Form Designer support
			//

			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			//
			VersionInfo.Text = CalcEngine.GetVersion();
			OutputDisplay.Text = "0";

            //--.
            standartSize();
            //--.
            toolTip = new ToolTip();
            //--.
            toolTip.SetToolTip(this.exponentiation, "Raising a number to a power");
            toolTip.SetToolTip(this.squareRoot, "Square root");
            toolTip.SetToolTip(this.reciprocalСalculation, "Calculating the reciprocal of a number");
            toolTip.SetToolTip(this.squareNumber, "Definition of the square of a number");
            toolTip.SetToolTip(this.calcFactorial, "Factorial calculation");
            toolTip.SetToolTip(this.cubeRoot, "Cube root extraction");
            toolTip.SetToolTip(this.solvQuadraticEquation, "Solving a quadratic equation");
            toolTip.SetToolTip(this.longOperation, "Lengthy operation of factorial calculation");
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.menuTopStrip = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareNumber = new System.Windows.Forms.Button();
            this.reciprocalСalculation = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.exponentiation = new System.Windows.Forms.Button();
            this.calcFactorial = new System.Windows.Forms.Button();
            this.cubeRoot = new System.Windows.Forms.Button();
            this.solvQuadraticEquation = new System.Windows.Forms.Button();
            this.longOperation = new System.Windows.Forms.Button();
            this.menuTopStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(320, 231);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(90, 59);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(13, 302);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(64, 58);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(13, 54);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(397, 27);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(166, 231);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(64, 59);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(90, 231);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(64, 59);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(320, 372);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(90, 58);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(90, 302);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(64, 58);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(13, 372);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(64, 58);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(166, 302);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(64, 58);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(243, 372);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(64, 58);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(320, 302);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(90, 58);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(166, 372);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(64, 58);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(13, 161);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(64, 59);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(90, 372);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(64, 58);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(166, 161);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(64, 59);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(13, 100);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(397, 35);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(243, 302);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(64, 58);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(90, 161);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(64, 59);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(243, 231);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(64, 59);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(13, 231);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(64, 59);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(320, 161);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(90, 59);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(243, 161);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(64, 59);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // menuTopStrip
            // 
            this.menuTopStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuTopStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuTopStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuTopStrip.Location = new System.Drawing.Point(0, 0);
            this.menuTopStrip.Name = "menuTopStrip";
            this.menuTopStrip.Size = new System.Drawing.Size(846, 36);
            this.menuTopStrip.TabIndex = 22;
            this.menuTopStrip.Text = "menuTopStrip";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.extendedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.standartToolStripMenuItem.Text = "&Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // extendedToolStripMenuItem
            // 
            this.extendedToolStripMenuItem.Name = "extendedToolStripMenuItem";
            this.extendedToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.extendedToolStripMenuItem.Text = "&Extended";
            this.extendedToolStripMenuItem.Click += new System.EventHandler(this.extendedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // squareNumber
            // 
            this.squareNumber.Font = new System.Drawing.Font("Arial", 12F);
            this.squareNumber.ForeColor = System.Drawing.Color.Red;
            this.squareNumber.Location = new System.Drawing.Point(657, 161);
            this.squareNumber.Name = "squareNumber";
            this.squareNumber.Size = new System.Drawing.Size(64, 59);
            this.squareNumber.TabIndex = 34;
            this.squareNumber.TabStop = false;
            this.squareNumber.Text = "x^2";
            this.squareNumber.Click += new System.EventHandler(this.squareNumber_Click);
            // 
            // reciprocalСalculation
            // 
            this.reciprocalСalculation.Font = new System.Drawing.Font("Arial", 12F);
            this.reciprocalСalculation.ForeColor = System.Drawing.Color.Red;
            this.reciprocalСalculation.Location = new System.Drawing.Point(580, 161);
            this.reciprocalСalculation.Name = "reciprocalСalculation";
            this.reciprocalСalculation.Size = new System.Drawing.Size(64, 59);
            this.reciprocalСalculation.TabIndex = 33;
            this.reciprocalСalculation.TabStop = false;
            this.reciprocalСalculation.Text = "1/x";
            this.reciprocalСalculation.Click += new System.EventHandler(this.reciprocalСalculation_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Font = new System.Drawing.Font("Arial", 15F);
            this.squareRoot.ForeColor = System.Drawing.Color.Red;
            this.squareRoot.Location = new System.Drawing.Point(504, 161);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(64, 59);
            this.squareRoot.TabIndex = 32;
            this.squareRoot.TabStop = false;
            this.squareRoot.Text = "√";
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // exponentiation
            // 
            this.exponentiation.Font = new System.Drawing.Font("Arial", 12F);
            this.exponentiation.ForeColor = System.Drawing.Color.Red;
            this.exponentiation.Location = new System.Drawing.Point(426, 161);
            this.exponentiation.Name = "exponentiation";
            this.exponentiation.Size = new System.Drawing.Size(64, 59);
            this.exponentiation.TabIndex = 31;
            this.exponentiation.TabStop = false;
            this.exponentiation.Text = "x^y";
            this.exponentiation.Click += new System.EventHandler(this.exponentiation_Click);
            // 
            // calcFactorial
            // 
            this.calcFactorial.Font = new System.Drawing.Font("Arial", 12F);
            this.calcFactorial.ForeColor = System.Drawing.Color.Red;
            this.calcFactorial.Location = new System.Drawing.Point(426, 231);
            this.calcFactorial.Name = "calcFactorial";
            this.calcFactorial.Size = new System.Drawing.Size(64, 59);
            this.calcFactorial.TabIndex = 35;
            this.calcFactorial.TabStop = false;
            this.calcFactorial.Text = "n!";
            this.calcFactorial.Click += new System.EventHandler(this.calcFactorial_Click);
            // 
            // cubeRoot
            // 
            this.cubeRoot.Font = new System.Drawing.Font("Arial", 12F);
            this.cubeRoot.ForeColor = System.Drawing.Color.Red;
            this.cubeRoot.Location = new System.Drawing.Point(504, 232);
            this.cubeRoot.Name = "cubeRoot";
            this.cubeRoot.Size = new System.Drawing.Size(64, 59);
            this.cubeRoot.TabIndex = 36;
            this.cubeRoot.TabStop = false;
            this.cubeRoot.Text = "3√";
            this.cubeRoot.Click += new System.EventHandler(this.cubeRoot_Click);
            // 
            // solvQuadraticEquation
            // 
            this.solvQuadraticEquation.Font = new System.Drawing.Font("Arial", 10F);
            this.solvQuadraticEquation.ForeColor = System.Drawing.Color.Red;
            this.solvQuadraticEquation.Location = new System.Drawing.Point(580, 232);
            this.solvQuadraticEquation.Name = "solvQuadraticEquation";
            this.solvQuadraticEquation.Size = new System.Drawing.Size(64, 58);
            this.solvQuadraticEquation.TabIndex = 37;
            this.solvQuadraticEquation.TabStop = false;
            this.solvQuadraticEquation.Text = "РКУ";
            this.solvQuadraticEquation.Click += new System.EventHandler(this.solvQuadraticEquation_Click);
            // 
            // longOperation
            // 
            this.longOperation.Font = new System.Drawing.Font("Arial", 10F);
            this.longOperation.ForeColor = System.Drawing.Color.Red;
            this.longOperation.Location = new System.Drawing.Point(426, 302);
            this.longOperation.Name = "longOperation";
            this.longOperation.Size = new System.Drawing.Size(142, 58);
            this.longOperation.TabIndex = 38;
            this.longOperation.TabStop = false;
            this.longOperation.Text = "n! long operation";
            this.longOperation.Click += new System.EventHandler(this.longOperation_Click);
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(846, 456);
            this.Controls.Add(this.longOperation);
            this.Controls.Add(this.solvQuadraticEquation);
            this.Controls.Add(this.cubeRoot);
            this.Controls.Add(this.calcFactorial);
            this.Controls.Add(this.squareNumber);
            this.Controls.Add(this.reciprocalСalculation);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.exponentiation);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuTopStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuTopStrip;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.TopMost = true;
            this.menuTopStrip.ResumeLayout(false);
            this.menuTopStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation( CalcEngine.Operator.eAdd );
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation( CalcEngine.Operator.eMultiply );
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation( CalcEngine.Operator.eDivide );
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber( fourOut );
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber (zeroOut);
		}

        //--.
        private void exponentiation_Click(object sender, EventArgs e)
        {
            //--. 
            CalcEngine.CalcOperation(CalcEngine.Operator.eExp);
        }

        //--.
        private void squareRoot_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSquareRoot);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        //--.
        private void reciprocalСalculation_Click(object sender, EventArgs e)
        {
            //--.
            CalcEngine.CalcOperation(CalcEngine.Operator.eReciprocal);
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        //--.
        private void squareNumber_Click(object sender, EventArgs e)
        {
            //--.
            CalcEngine.CalcOperation(CalcEngine.Operator.eExp);
            CalcEngine.setManualAnswer("2");
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }


        //
        // End the program.
        //

        protected void KeyExit_Click (object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        //--.
        protected void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            MessageBox.Show("Simple Calculator App\nVersion 2.0.1.1\n(c) 2024 Itmo", "About Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //--.
        private void standartSize()
        {
            //--.
            this.Width = 440;
            VersionInfo.Width = 397;
            OutputDisplay.Width = 397;
        }

        //--.
        private void extendedSize()
        {
            //--.
            this.Width = 760;
            VersionInfo.Width = 708;
            OutputDisplay.Width = 708;
        }

        //--.
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standartSize();
        }

        //--.
        private void extendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            extendedSize();
        }

        //--.
        private void calcFactorial_Click(object sender, EventArgs e)
        {
            //--.
            CalcEngine.CalcOperation(CalcEngine.Operator.eFactorial);
            CalcEngine.CalcEqual();
            OutputDisplay.Text = CalcEngine.resFactNumericAnswer.ToString(); //CalcEqual();
            CalcEngine.CalcReset();
        }

        private void cubeRoot_Click(object sender, EventArgs e)
        {
            //--.
            CalcEngine.CalcOperation(CalcEngine.Operator.eExp);
            CalcEngine.setManualAnswer("0,3333333333333333");
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }


        //--.
        private void showInputSQEDialog()
        {
            using(var form = new InputFormSolvQE()) 
            { 
                if(form.ShowDialog() == DialogResult.OK) 
                {
                    double a, b, c, x1 = 0, x2 = 0;
                    int ret;

                    //--.
                    a = Double.Parse(form.valueA);
                    b = Double.Parse(form.valueB);
                    c = Double.Parse(form.valueC);

                    //--.
                    ///MessageBox.Show($"a: {a}, b: {b}, c: {c}");

                    //--.
                    ret = CalcEngine.solutionQuadraticEquation(a, b, c, ref x1, ref x2);

                    //--.
                    switch (ret)
                    {
                        case 0:
                            OutputDisplay.Text = $"Корень ур-я с коэфф. a={a:F2};b={b:F2};c={c:F2} один: x1 = x2 = {x1:F2}";
                            break;
                        case 1:
                            OutputDisplay.Text = $"Корни ур-я с коэфф. a={a:F2};b={b:F2};c={c:F2}: x1={x1:F2}; x2={x2:F2}";
                            break;
                        case -1:
                            OutputDisplay.Text = $"Корней ур-я с коэфф. a={a:F2};b={b:F2};c={c:F2} нет ";
                            break;
                    }

                }

            }
        }


        //--.
        private void solvQuadraticEquation_Click(object sender, EventArgs e)
        {
            //--.
            showInputSQEDialog();
        }

        //--.
        private async void longOperation_Click(object sender, EventArgs e)
        {
            //--. lock the button to prevent it from being pressed again
            longOperation.Enabled = false;

            //--. calling an asynchronous method to calculate the factorial
            BigInteger result = await calcFactorialAsync(int.Parse(OutputDisplay.Text));

            //--. displaying the result in a text field
            OutputDisplay.Text = result.ToString();

            //--.
            CalcEngine.CalcReset();

            //--.
            longOperation.Enabled = true;
        }

        //--.
        private async Task<BigInteger> calcFactorialAsync(int n)
        {
            //--. running a task to calculate the factorial in a separate thread
            return await Task.Run(() => calculateFact(n));
        }   

        //--.
        private BigInteger calculateFact(int n) 
        {
            BigInteger factorial = 1; 
            for(int i=1; i<=n; i++)
            {
                factorial *= i;
                Thread.Sleep(500);
                UpdateTextBox( factorial.ToString() );
            }
            
            return factorial;
        }

        //--.
        private void UpdateTextBox(string text)
        {
            if(OutputDisplay.InvokeRequired)
            {
                OutputDisplay.Invoke(new Action<string>(UpdateTextBox), text);
            }
            else 
            {
                OutputDisplay.Text = text;
            }
        }
    }
}
