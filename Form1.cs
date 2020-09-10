///
/// UserInterface.cs
/// Author: Erik Lewis
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
namespace KSU.CIS300.TowersOfHanoi
{
    public partial class UserInterface : Form
    {
        
        public int Moves { get; private set; }
        public bool TestMode { get; set; }
        public Stack<int> PegA = new Stack<int>();
        public Stack<int> PegB = new Stack<int>();
        public Stack<int> PegC = new Stack<int>();
        private int _discCount;

        public UserInterface()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Creates the Disc that you see on the userinterface
        /// </summary>
        /// <param name="number"></param>
        /// <param name="panel"></param>
        private void DrawDisc(int number, FlowLayoutPanel panel)
        {
            Label Disc = new Label();
            Disc.Width = (int)(panel.Width / (_discCount - number + 1.25));
            int temp = (panel.Width - Disc.Width) / 2;
            Disc.Margin = new Padding(temp, 0, temp, 0);
            if (number % 2 == 1)
            {
                Disc.BackColor = Color.LightBlue;
            }
            else
            {
                Disc.BackColor = Color.Orange;
            }
            Disc.Text = number.ToString();
            Disc.TextAlign = ContentAlignment.MiddleCenter;
            panel.Controls.Add(Disc);
        }
        /// <summary>
        /// Removes all controls from they panel used as input
        /// </summary>
        /// <param name="panel"></param>
        private void CleanPanel(FlowLayoutPanel panel)
        {
            Stack<Control> controls = new Stack<Control>();

            foreach (Control em in panel.Controls)
            {
                controls.Push(em);
            }

            foreach (Control em in controls)
            {
                panel.Controls.Remove(em);
                em.Dispose();
            }


        }

        /// <summary>
        /// Creates a new puzzle, clears existing discs and adds new ones.
        /// </summary>
        /// <param name="count"></param>

        public void NewPuzzle(int count)
        {
            uxMoveCountNum.Text = "0";
            Moves = 0;

            PegA.Clear();
            PegB.Clear();
            PegC.Clear();


            CleanPanel(uxFlowLayoutPanel1);
            CleanPanel(uxFlowLayoutPanel2);
            CleanPanel(uxFlowLayoutPanel3);
            _discCount = count;
            for (int i = _discCount; i > 0; i--)
            {
                DrawDisc(i, uxFlowLayoutPanel1);
                PegA.Push(i);
            }

        }

        /// <summary>
        /// Checks to see if any discs have been moved, and updates the stack counts accordingly
        /// </summary>
        /// <param name="source"></param>
        /// <param name="sourceStack"></param>
        /// <param name="dest"></param>
        /// <param name="destStack"></param>
        /// <param name="alt"></param>
        /// <param name="altStack"></param>
        /// <returns></returns>
        private bool UpdatePanelHelper(FlowLayoutPanel source, Stack<int> sourceStack, FlowLayoutPanel dest, Stack<int> destStack, FlowLayoutPanel alt, Stack<int> altStack)
        {
            if (source.Controls.Count > sourceStack.Count)
            {
                if (dest.Controls.Count < destStack.Count)
                {

                    DrawDisc(destStack.Peek(), dest);
                    source.Controls.RemoveAt(source.Controls.Count - 1);

                    dest.Update();

                }
                else
                {
                    DrawDisc(altStack.Peek(), alt);
                    source.Controls.RemoveAt(source.Controls.Count - 1);

                    alt.Update();
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks to see if disc is able to move to the destination peg
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>

        public bool CheckMove(Stack<int> from, Stack<int> to)
        {
            if ((to.Count != 0) && (from.Count() != 0))
            {
                if (to.Peek() > from.Peek())
                {
                    to.Push(from.Pop());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if ((to.Count == 0) && (from.Count() != 0))
            {
                to.Push(from.Pop());
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Changes the stack counts of the to and from pegs
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public bool MoveDisc(Stack<int> from, Stack<int> to)
        {
            if (from.Count != 0)
            {
                if (to.Count != 0)
                {
                    if (to.Peek() > from.Peek())
                    {
                        to.Push(from.Pop());
                        Moves++;
                        uxMoveCountNum.Text = Moves.ToString();


                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    to.Push(from.Pop());
                    Moves++;
                    uxMoveCountNum.Text = Moves.ToString();


                    return true;
                }
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines if x can move to y or if y can move to x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="delay"></param>
        public void MoveEither(Stack<int> x, Stack<int> y, int delay)
        {
            if (CheckMove(x, y))
            {
                MoveDisc(x, y);
            }
            else if (CheckMove(y, x))
            {
                MoveDisc(y, x);
            }
            Thread.Sleep(delay);
        }
        /// <summary>
        /// Checks for win conditions met and displays if optimal and/or if you used the optimal amount of moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFlowLayoutPanel3_ControlAdded(object sender, ControlEventArgs e)
        {
            if ((PegC.Count == _discCount) && (PegA.Count == 0) && (PegB.Count == 0))
            {
                int optimal = (int)Math.Pow(2, _discCount) - 1;
                if (Moves == optimal)
                {
                    MessageBox.Show("You won in " + Moves + " moves" + "\n" + "This is the optimal amount of moves");
                }
                else
                {
                    MessageBox.Show("You won in " + Moves + " moves" + "\n" + "The optimal amount of moves was " + optimal);
                }
            }
        }
        /// <summary>
        /// uses solve method when solve button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSolve_Click(object sender, EventArgs e)
        {
            Solve(PegC, PegB, (int)numericUpDown1.Value);
        }
        /// <summary>
        /// solve method used when you click solve
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="delay"></param>
        public void Solve(Stack<int> x, Stack<int> y, int delay)
        {

            while (PegC.Count != _discCount)
            {
                //int i = 0;
                if (PegC.Count != _discCount)
                {
                    Moves++;
                    MoveEither(PegA, x, delay);
                    uxMoveCountNum.Text = Moves.ToString();
                    UpdatePanels();
                }
                if (PegC.Count != _discCount)
                {
                    Moves++;
                    MoveEither(PegA, y, delay);
                    uxMoveCountNum.Text = Moves.ToString();
                    UpdatePanels();
                }
                if (PegC.Count != _discCount)
                {
                    Moves++;
                    MoveEither(PegB, PegC, delay);
                    uxMoveCountNum.Text = Moves.ToString();
                    UpdatePanels();
                }
            }
        }

        /// <summary>
        /// Keeps the UI updated with disc locations
        /// </summary>
        private void UpdatePanels()
        {
            UpdatePanelHelper(uxFlowLayoutPanel1, PegA, uxFlowLayoutPanel2, PegB, uxFlowLayoutPanel3, PegC);
            UpdatePanelHelper(uxFlowLayoutPanel1, PegA, uxFlowLayoutPanel3, PegC, uxFlowLayoutPanel2, PegB);

            UpdatePanelHelper(uxFlowLayoutPanel2, PegB, uxFlowLayoutPanel1, PegA, uxFlowLayoutPanel3, PegC);
            UpdatePanelHelper(uxFlowLayoutPanel2, PegB, uxFlowLayoutPanel3, PegC, uxFlowLayoutPanel1, PegA);

            UpdatePanelHelper(uxFlowLayoutPanel3, PegC, uxFlowLayoutPanel1, PegA, uxFlowLayoutPanel2, PegB);
            UpdatePanelHelper(uxFlowLayoutPanel3, PegC, uxFlowLayoutPanel2, PegB, uxFlowLayoutPanel1, PegA);
        }

        /// <summary>
        /// draws new puzzle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNew_Click(object sender, EventArgs e)
        {
            NewPuzzle((int)uxNumericUpDown1.Value);
        }


        private void uxMoveCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // All of the following methods are used to move discs with their corresponding directions
        private void uxMoveLeft1_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegA, PegC) == true)
            {
                UpdatePanels();

            }
        }

        private void uxMoveRight1_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegA, PegB) == true)
            {
                UpdatePanels();
            }
        }

        private void uxMoveLeft2_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegB, PegA) == true)
            {
                UpdatePanels();
            }
        }

        private void uxMoveRight2_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegB, PegC) == true)
            {
                UpdatePanels();
            }
        }

        private void uxMoveLeft3_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegC, PegB) == true)
            {
                UpdatePanels();
            }
        }

        private void uxMoveRight3_Click(object sender, EventArgs e)
        {
            if (MoveDisc(PegC, PegA) == true)
            {
                UpdatePanels();
            }
        }


    }
}*/



//TEST CODE; TO BE REMOVED; this was my outdated click sets that more than likely wouldn't function properly
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void New_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MoveCount_Click(object sender, EventArgs e)
        {

        }

        private void MoveCountNum_Click(object sender, EventArgs e)
        {

        }

        private void Solve_Click(object sender, EventArgs e)
        {

        }

        private void Delay_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoveLeft1_Click(object sender, EventArgs e)
        {

        }

        private void MoveRight1_Click(object sender, EventArgs e)
        {

        }

        private void MoveLeft2_Click(object sender, EventArgs e)
        {

        }

        private void MoveRight2_Click(object sender, EventArgs e)
        {

        }

        private void MoveLeft3_Click(object sender, EventArgs e)
        {

        }

        private void MoveRight3_Click(object sender, EventArgs e)
        {

        }
    }
}
