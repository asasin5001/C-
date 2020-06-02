using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        [DllImport("dwmapi.dll")]
        static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        public Form1()
        {
            InitializeComponent();
            AeroGlass(true);
        }
        static Color ColorsBackColor(int i)
        {
            Color[] colors = { Color.Silver, Color.Red, Color.Green, Color.Blue, Color.White };
            return colors[i];
        }
        void AeroGlass(bool _enabled)
        {
            MARGINS _margins = new MARGINS();
            _margins.bottomHeight = 23;
            if (_enabled)
            {
                DwmExtendFrameIntoClientArea(this.Handle, ref _margins);
            }

        }
        private void MatricesM_Click(object sender, System.EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({MatricesM.Text}):";
                matrixAB1.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB4.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB7.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB9.Text))).ToString();
                matrixAB2.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB5.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB8.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB9.Text))).ToString();
                matrixAB3.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB6.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB9.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB9.Text))).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void MatricesS_Click(object sender, System.EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({MatricesS.Text}):";
                matrixAB1.Text = (int.Parse(matrixA1.Text) + int.Parse(matrixB1.Text)).ToString();
                matrixAB2.Text = (int.Parse(matrixA2.Text) + int.Parse(matrixB2.Text)).ToString();
                matrixAB3.Text = (int.Parse(matrixA3.Text) + int.Parse(matrixB3.Text)).ToString();
                matrixAB4.Text = (int.Parse(matrixA4.Text) + int.Parse(matrixB4.Text)).ToString();
                matrixAB5.Text = (int.Parse(matrixA5.Text) + int.Parse(matrixB5.Text)).ToString();
                matrixAB6.Text = (int.Parse(matrixA6.Text) + int.Parse(matrixB6.Text)).ToString();
                matrixAB7.Text = (int.Parse(matrixA7.Text) + int.Parse(matrixB7.Text)).ToString();
                matrixAB8.Text = (int.Parse(matrixA8.Text) + int.Parse(matrixB8.Text)).ToString();
                matrixAB9.Text = (int.Parse(matrixA9.Text) + int.Parse(matrixB9.Text)).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void MatricesD_Click(object sender, System.EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({MatricesD.Text}):";
                matrixAB1.Text = (int.Parse(matrixA1.Text) - int.Parse(matrixB1.Text)).ToString();
                matrixAB2.Text = (int.Parse(matrixA2.Text) - int.Parse(matrixB2.Text)).ToString();
                matrixAB3.Text = (int.Parse(matrixA3.Text) - int.Parse(matrixB3.Text)).ToString();
                matrixAB4.Text = (int.Parse(matrixA4.Text) - int.Parse(matrixB4.Text)).ToString();
                matrixAB5.Text = (int.Parse(matrixA5.Text) - int.Parse(matrixB5.Text)).ToString();
                matrixAB6.Text = (int.Parse(matrixA6.Text) - int.Parse(matrixB6.Text)).ToString();
                matrixAB7.Text = (int.Parse(matrixA7.Text) - int.Parse(matrixB7.Text)).ToString();
                matrixAB8.Text = (int.Parse(matrixA8.Text) - int.Parse(matrixB8.Text)).ToString();
                matrixAB9.Text = (int.Parse(matrixA9.Text) - int.Parse(matrixB9.Text)).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }

        }
        private void очиститьМатрицуAToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            TextBox[] MatricesATextBox = { matrixA1, matrixA2, matrixA3, matrixA4, matrixA5, matrixA6, matrixA7, matrixA8, matrixA9 };
            foreach (var MatricesA in MatricesATextBox)
                MatricesA.Clear();
        }
        private void очиститьМатрицуBToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            TextBox[] MatricesBTextBox = { matrixB1, matrixB2, matrixB3, matrixB4, matrixB5, matrixB6, matrixB7, matrixB8, matrixB9 };
            foreach (var MatricesB in MatricesBTextBox)
                MatricesB.Clear();
        }
        private void очиститьМатрицуAИBToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            TextBox[] MatricesABTextBox = { matrixA1, matrixA2, matrixA3, matrixA4, matrixA5, matrixA6, matrixA7, matrixA8, matrixA9, matrixB1, matrixB2, matrixB3, matrixB4, matrixB5, matrixB6, matrixB7, matrixB8, matrixB9 };
            foreach (var MatricesAB in MatricesABTextBox)
                MatricesAB.Clear();
        }
        private void очиститьВсёToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            TextBox[] AllMatricesTextBox = { matrixA1, matrixA2, matrixA3, matrixA4, matrixA5, matrixA6, matrixA7, matrixA8, matrixA9, matrixB1, matrixB2, matrixB3, matrixB4, matrixB5, matrixB6, matrixB7, matrixB8, matrixB9, matrixAB1, matrixAB2, matrixAB3, matrixAB4, matrixAB5, matrixAB6, matrixAB7, matrixAB8, matrixAB9 };
            foreach (var AllMatrices in AllMatricesTextBox)
                AllMatrices.Clear();
        }
        private void MatricesChange_Click(object sender, System.EventArgs e)
        {
            try
            {
                string stack = String.Empty;
                stack = matrixA1.Text;
                matrixA1.Text = matrixB1.Text;
                matrixB1.Text = stack;
                stack = matrixA4.Text;
                matrixA4.Text = matrixB4.Text;
                matrixB4.Text = stack;
                stack = matrixA7.Text;
                matrixA7.Text = matrixB7.Text;
                matrixB7.Text = stack;
                stack = matrixA2.Text;
                matrixA2.Text = matrixB2.Text;
                matrixB2.Text = stack;
                stack = matrixA5.Text;
                matrixA5.Text = matrixB5.Text;
                matrixB5.Text = stack;
                stack = matrixA8.Text;
                matrixA8.Text = matrixB8.Text;
                matrixB8.Text = stack;
                stack = matrixA3.Text;
                matrixA3.Text = matrixB3.Text;
                matrixB3.Text = stack;
                stack = matrixA6.Text;
                matrixA6.Text = matrixB6.Text;
                matrixB6.Text = stack;
                stack = matrixA9.Text;
                matrixA9.Text = matrixB9.Text;
                matrixB9.Text = stack;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void MultiplyMatricesA_Click(object sender, EventArgs e)
        {
            try
            {
                matrixA1.Text = (int.Parse(matrixA1.Text) * numericMatricesA.Value).ToString();
                matrixA4.Text = (int.Parse(matrixA4.Text) * numericMatricesA.Value).ToString();
                matrixA7.Text = (int.Parse(matrixA7.Text) * numericMatricesA.Value).ToString();
                matrixA2.Text = (int.Parse(matrixA2.Text) * numericMatricesA.Value).ToString();
                matrixA5.Text = (int.Parse(matrixA5.Text) * numericMatricesA.Value).ToString();
                matrixA8.Text = (int.Parse(matrixA8.Text) * numericMatricesA.Value).ToString();
                matrixA3.Text = (int.Parse(matrixA3.Text) * numericMatricesA.Value).ToString();
                matrixA6.Text = (int.Parse(matrixA6.Text) * numericMatricesA.Value).ToString();
                matrixA9.Text = (int.Parse(matrixA9.Text) * numericMatricesA.Value).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }

        private void MultiplyMatricesB_Click(object sender, EventArgs e)
        {
            try
            {
                matrixB1.Text = (int.Parse(matrixB1.Text) * numericMatricesB.Value).ToString();
                matrixB4.Text = (int.Parse(matrixB4.Text) * numericMatricesB.Value).ToString();
                matrixB7.Text = (int.Parse(matrixB7.Text) * numericMatricesB.Value).ToString();
                matrixB2.Text = (int.Parse(matrixB2.Text) * numericMatricesB.Value).ToString();
                matrixB5.Text = (int.Parse(matrixB5.Text) * numericMatricesB.Value).ToString();
                matrixB8.Text = (int.Parse(matrixB8.Text) * numericMatricesB.Value).ToString();
                matrixB3.Text = (int.Parse(matrixB3.Text) * numericMatricesB.Value).ToString();
                matrixB6.Text = (int.Parse(matrixB6.Text) * numericMatricesB.Value).ToString();
                matrixB9.Text = (int.Parse(matrixB9.Text) * numericMatricesB.Value).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void TransposeMatricesA_Click(object sender, EventArgs e)
        {
            try
            {
                string stackTransposeA = String.Empty;
                stackTransposeA = matrixA1.Text;
                matrixA1.Text = matrixA1.Text;
                matrixA1.Text = stackTransposeA;
                stackTransposeA = matrixA2.Text;
                matrixA2.Text = matrixA4.Text;
                matrixA4.Text = stackTransposeA;
                stackTransposeA = matrixA3.Text;
                matrixA3.Text = matrixA7.Text;
                matrixA7.Text = stackTransposeA;
                stackTransposeA = matrixA5.Text;
                matrixA5.Text = matrixA5.Text;
                matrixA5.Text = stackTransposeA;
                stackTransposeA = matrixA6.Text;
                matrixA6.Text = matrixA8.Text;
                matrixA8.Text = stackTransposeA;
                stackTransposeA = matrixA9.Text;
                matrixA9.Text = matrixA9.Text;
                matrixA9.Text = stackTransposeA;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void TransposeMatricesB_Click(object sender, EventArgs e)
        {
            try
            {
                string stackTransposeB = String.Empty;
                stackTransposeB = matrixB1.Text;
                matrixB1.Text = matrixB1.Text;
                matrixB1.Text = stackTransposeB;
                stackTransposeB = matrixB2.Text;
                matrixB2.Text = matrixB4.Text;
                matrixB4.Text = stackTransposeB;
                stackTransposeB = matrixB3.Text;
                matrixB3.Text = matrixB7.Text;
                matrixB7.Text = stackTransposeB;
                stackTransposeB = matrixB5.Text;
                matrixB5.Text = matrixB5.Text;
                matrixB5.Text = stackTransposeB;
                stackTransposeB = matrixB6.Text;
                matrixB6.Text = matrixB8.Text;
                matrixB8.Text = stackTransposeB;
                stackTransposeB = matrixB9.Text;
                matrixB9.Text = matrixB9.Text;
                matrixB9.Text = stackTransposeB;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус:" + exc.Message;
            }
        }
        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorsBackColor(0);
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorsBackColor(1);
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorsBackColor(2);
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorsBackColor(3);
        }
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorsBackColor(4);
        }
    }
}