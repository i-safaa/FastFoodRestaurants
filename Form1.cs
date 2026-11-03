using System;
using System.Windows.Forms;

namespace FastFoodRestaurants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFries.Checked == true)
            {
                txtFries.Enabled = true;
            }
            if (checkFries.Checked == false)
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void checkBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBurger.Checked == true)
            {
                txtBurger.Enabled = true;
            }
            if (checkBurger.Checked == false)
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "0";
            }
        }

        private void checkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSalad.Checked == true)
            {
                txtSalad.Enabled = true;
            }
            if (checkSalad.Checked == false)
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void checkSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSandwich.Checked == true)
            {
                txtSandwich.Enabled = true;
            }
            if (checkSandwich.Checked == false)
            {
                txtSandwich.Enabled = false;
                txtSandwich.Text = "0";
            }
        }

        private void checkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChicken.Checked == true)
            {
                txtChicken.Enabled = true;
            }
            if (checkChicken.Checked == false)
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void checkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCheese.Checked == true)
            {
                txtCheese.Enabled = true;
            }
            if (checkCheese.Checked == false)
            {
                txtCheese.Enabled = false;
                txtCheese.Text = "0";
            }
        }

        private void checkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTea.Checked == true)
            {
                txtTea.Enabled = true;
            }
            if (checkTea.Checked == false)
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void checkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCola.Checked == true)
            {
                txtCola.Enabled = true;
            }
            if (checkCola.Checked == false)
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void checkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWater.Checked == true)
            {
                txtWater.Enabled = true;
            }
            if (checkWater.Checked == false)
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void checkChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChocolate.Checked == true)
            {
                txtChocilate.Enabled = true;
            }
            if (checkChocolate.Checked == false)
            {
                txtChocilate.Enabled = false;
                txtChocilate.Text = "0";
            }
        }

        private void checkPanckes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPanckes.Checked == true)
            {
                txtPanckes.Enabled = true;
            }
            if (checkPanckes.Checked == false)
            {
                txtPanckes.Enabled = false;
                txtPanckes.Text = "0";
            }
        }

        private void checkOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOrange.Checked == true)
            {
                txtOrange.Enabled = true;
            }
            if (checkOrange.Checked == false)
            {
                txtOrange.Enabled = false;
                txtOrange.Text = "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // أسعار العناصر (يمكنك تعديلها حسب رغبتك)
            double priceFries = 2.0, priceBurger = 5.0, priceSalad = 3.0;
            double priceSandwich = 4.5, priceChicken = 6.0, priceCheese = 1.5;
            double priceTea = 1.0, priceCola = 1.5, priceWater = 0.5;
            double priceChocolate = 2.5, pricePancakes = 3.5, priceOrange = 2.0;

            double subTotal = 0;

            try
            {
                if (checkFries.Checked) subTotal += Convert.ToDouble(txtFries.Text) * priceFries;
                if (checkBurger.Checked) subTotal += Convert.ToDouble(txtBurger.Text) * priceBurger;
                if (checkSalad.Checked) subTotal += Convert.ToDouble(txtSalad.Text) * priceSalad;
                if (checkSandwich.Checked) subTotal += Convert.ToDouble(txtSandwich.Text) * priceSandwich;
                if (checkChicken.Checked) subTotal += Convert.ToDouble(txtChicken.Text) * priceChicken;
                if (checkCheese.Checked) subTotal += Convert.ToDouble(txtCheese.Text) * priceCheese;
                if (checkTea.Checked) subTotal += Convert.ToDouble(txtTea.Text) * priceTea;
                if (checkCola.Checked) subTotal += Convert.ToDouble(txtCola.Text) * priceCola;
                if (checkWater.Checked) subTotal += Convert.ToDouble(txtWater.Text) * priceWater;
                if (checkChocolate.Checked) subTotal += Convert.ToDouble(txtChocilate.Text) * priceChocolate;
                if (checkPanckes.Checked) subTotal += Convert.ToDouble(txtPanckes.Text) * pricePancakes;
                if (checkOrange.Checked) subTotal += Convert.ToDouble(txtOrange.Text) * priceOrange;

                double tax = subTotal * 0.10; // حساب ضريبة 10%
                double total = subTotal + tax;

                // تحديث الـ Labels بالقيم المحسوبة مع تنسيقها برقمين عشريين
                lblSubTotal.Text = subTotal.ToString("F2") + " $";
                lblTax.Text = tax.ToString("F2") + " $";
                lblTotal.Text = total.ToString("F2") + " $";

                // طباعة الفاتورة في الـ RichTextBox
                richTextBox1.Clear();
                richTextBox1.AppendText("====================================\n");
                richTextBox1.AppendText("          Fast Food Restaurant      \n");
                richTextBox1.AppendText("          Receipt: " + DateTime.Now.ToString() + "\n");
                richTextBox1.AppendText("====================================\n");

                if (checkFries.Checked) richTextBox1.AppendText($"Fries x {txtFries.Text}\t\t= ${Convert.ToDouble(txtFries.Text) * priceFries:F2}\n");
                if (checkBurger.Checked) richTextBox1.AppendText($"Burger x {txtBurger.Text}\t\t= ${Convert.ToDouble(txtBurger.Text) * priceBurger:F2}\n");
                if (checkSalad.Checked) richTextBox1.AppendText($"Salad x {txtSalad.Text}\t\t= ${Convert.ToDouble(txtSalad.Text) * priceSalad:F2}\n");
                if (checkSandwich.Checked) richTextBox1.AppendText($"Sandwich x {txtSandwich.Text}\t= ${Convert.ToDouble(txtSandwich.Text) * priceSandwich:F2}\n");
                if (checkChicken.Checked) richTextBox1.AppendText($"Chicken x {txtChicken.Text}\t\t= ${Convert.ToDouble(txtChicken.Text) * priceChicken:F2}\n");
                if (checkCheese.Checked) richTextBox1.AppendText($"Cheese x {txtCheese.Text}\t\t= ${Convert.ToDouble(txtCheese.Text) * priceCheese:F2}\n");
                if (checkTea.Checked) richTextBox1.AppendText($"Tea x {txtTea.Text}\t\t= ${Convert.ToDouble(txtTea.Text) * priceTea:F2}\n");
                if (checkCola.Checked) richTextBox1.AppendText($"Cola x {txtCola.Text}\t\t= ${Convert.ToDouble(txtCola.Text) * priceCola:F2}\n");
                if (checkWater.Checked) richTextBox1.AppendText($"Water x {txtWater.Text}\t\t= ${Convert.ToDouble(txtWater.Text) * priceWater:F2}\n");
                if (checkChocolate.Checked) richTextBox1.AppendText($"Chocolate x {txtChocilate.Text}\t= ${Convert.ToDouble(txtChocilate.Text) * priceChocolate:F2}\n");
                if (checkPanckes.Checked) richTextBox1.AppendText($"Pancakes x {txtPanckes.Text}\t= ${Convert.ToDouble(txtPanckes.Text) * pricePancakes:F2}\n");
                if (checkOrange.Checked) richTextBox1.AppendText($"Orange Juice x {txtOrange.Text}\t= ${Convert.ToDouble(txtOrange.Text) * priceOrange:F2}\n");

                richTextBox1.AppendText("------------------------------------\n");
                richTextBox1.AppendText($"Subtotal:\t\t${subTotal:F2}\n");
                richTextBox1.AppendText($"Tax (10%):\t\t${tax:F2}\n");
                richTextBox1.AppendText($"Total Amount:\t\t${total:F2}\n");
                richTextBox1.AppendText("====================================\n");
                richTextBox1.AppendText("      Thank you for your order!     \n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("الرجاء التأكد من إدخال أرقام صحيحة للكميات.", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // إلغاء تحديد جميع الـ Checkboxes
            checkFries.Checked = false;
            checkBurger.Checked = false;
            checkSalad.Checked = false;
            checkSandwich.Checked = false;
            checkChicken.Checked = false;
            checkCheese.Checked = false;
            checkTea.Checked = false;
            checkCola.Checked = false;
            checkWater.Checked = false;
            checkChocolate.Checked = false;
            checkPanckes.Checked = false;
            checkOrange.Checked = false;

            // إعادة تعيين الـ Labels إلى قيم صفرية
            lblSubTotal.Text = "0.00 $";
            lblTax.Text = "0.00 $";
            lblTotal.Text = "0.00 $";

            // مسح محتوى الفاتورة
            richTextBox1.Clear();
        }

        // 1. حدث طباعة الصفحة (يحدد شكل وطريقة طباعة النص)
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // رسم النص الموجود في الـ RichTextBox على ورقة الطباعة
            e.Graphics.DrawString(richTextBox1.Text, new System.Drawing.Font("Consolas", 11), System.Drawing.Brushes.Black, 10, 10);
        }

        // 2. تحديث كود زر الطباعة btnPrint_Click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
                System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

                // ربط المستند بحدث الطباعة
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print(); // تنفيذ عملية الطباعة الفعلية
                    MessageBox.Show("تم إرسال الفاتورة إلى الطابعة بنجاح.", "طباعة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء محاولة الطباعة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
