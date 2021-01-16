using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHWÖzge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            africantxt.Text = "0";
            americantxt.Text = "0";
            lattetxt.Text = "0";
            expressotxt.Text = "0";
            icedlattetxt.Text = "0";
            valetxt.Text = "0";
            cappuccinotxt.Text = "0";
            icedcptxt.Text = "0";
            coffeetxt.Text = "0";
            redvelvettxt.Text = "0";
            blutxt.Text = "0";
            yellowtxt.Text = "0";
            chocolatetxt.Text = "0";
            creamtxt.Text = "0";
            carrottxt.Text = "0";
            whitetxt.Text = "0";
            drinkstxt.Text = "0";
            cakestxt.Text = "0";
            servicetxt.Text = "1.75";

            lattetxt.Enabled = false;
            expressotxt.Enabled = false;
            icedlattetxt.Enabled = false;
            valetxt.Enabled = false;
            cappuccinotxt.Enabled = false;
            africantxt.Enabled = false;
            americantxt.Enabled = false;
            icedcptxt.Enabled = false;
            coffeetxt.Enabled = false;
            redvelvettxt.Enabled = false;
            blutxt.Enabled = false;
            yellowtxt.Enabled = false;
            chocolatetxt.Enabled = false;
            creamtxt.Enabled = false;
            carrottxt.Enabled = false;
            whitetxt.Enabled = false;

            latte.Checked = false;
            expresso.Checked = false;
            icedlatte.Checked = false;
            valecoffee.Checked = false;
            cappuccino.Checked = false;
            africancoffee.Checked = false;
            americancoffee.Checked = false;
            icedcappuccino.Checked = false;
            coffeecake.Checked = false;
            redvelvet.Checked = false;
            bluecake.Checked = false;
            yellowcake.Checked = false;
            chocolatecake.Checked = false;
            creamcake.Checked = false;
            carrotcake.Checked = false;
            whitecake.Checked = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

      
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        //ResetButton
        private void btnreset_Click_1(object sender, EventArgs e)
        {
            africantxt.Text = "0";
            americantxt.Text = "0";
            lattetxt.Text = "0";
            expressotxt.Text = "0";
            icedlattetxt.Text = "0";
            valetxt.Text = "0";
            cappuccinotxt.Text = "0";
            icedcptxt.Text = "0";
            coffeetxt.Text = "0";
            redvelvettxt.Text = "0";
            blutxt.Text = "0";
            yellowtxt.Text = "0";
            chocolatetxt.Text = "0";
            creamtxt.Text = "0";
            carrottxt.Text = "0";
            whitetxt.Text = "0";
            drinkstxt.Text = "0";
            cakestxt.Text = "0";
            servicetxt.Text = "1.75";
            subtotaltxt.Text = "0";
            taxtxt.Text = "0";
            totaltxt.Text = "0";

            latte.Checked = false;
            expresso.Checked = false;
            icedlatte.Checked = false;
            valecoffee.Checked = false;
            cappuccino.Checked = false;
            africancoffee.Checked = false;
            americancoffee.Checked = false;
            icedcappuccino.Checked = false;
            coffeecake.Checked = false;
            redvelvet.Checked = false;
            bluecake.Checked = false;
            yellowcake.Checked = false;
            chocolatecake.Checked = false;
            creamcake.Checked = false;
            carrotcake.Checked = false;
            whitecake.Checked = false;
        }

        //Latte
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (latte.Checked == true)
            {
                lattetxt.Enabled = true;
            }
            if (latte.Checked == false)
            {
                lattetxt.Enabled = false;
                lattetxt.Text = "0";
            }
        }
        private void lattetxt_TextChanged(object sender, EventArgs e)
        {
            //lattetxt.Text = "0";
            lattetxt.Focus();
        }
        //Expresso
        private void expresso_CheckedChanged(object sender, EventArgs e)
        {
            if(expresso.Checked == true)
            {
                expressotxt.Enabled = true;
            }
            if (expresso.Checked == false)
            {
                expressotxt.Enabled = false;
                expressotxt.Text = "0";

            }
        }
        private void expressotxt_TextChanged(object sender, EventArgs e)
        {
            //expressotxt.Text = "0";
            expressotxt.Focus();
        }
        //IcedLatte
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (icedlatte.Checked == true)
            {
                icedlattetxt.Enabled = true;
            }
            if (icedlatte.Checked == false)
            {
                icedlattetxt.Enabled = false;
                icedlattetxt.Text = "0";
            }
        }
        private void icedlattetxt_TextChanged(object sender, EventArgs e)
        {
            //icedlattetxt.Text = "0";
            icedlattetxt.Focus();
        }
        //ValeCoffee
        private void valecoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (valecoffee.Checked == true)
            {
                valetxt.Enabled = true;
            }
            if (valecoffee.Checked == false)
            {
                valetxt.Enabled = false;
                valetxt.Text = "0";
            }
        }
        private void valetxt_TextChanged(object sender, EventArgs e)
        {
            //valetxt.Text = "0";
            valetxt.Focus();
        }
        //Cappuccino
        private void cappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cappuccino.Checked == true)
            {
                cappuccinotxt.Enabled = true;
            }
            if (cappuccino.Checked == false)
            {
                cappuccinotxt.Enabled = false;
                cappuccinotxt.Text = "0";
            }
        }
        private void cappuccinotxt_TextChanged(object sender, EventArgs e)
        {
            //cappuccinotxt.Text = "0";
            cappuccinotxt.Focus();
        }

        //AfricanCoffee
        private void africancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (africancoffee.Checked == true)
            {
                africantxt.Enabled = true;
            }
            if (africancoffee.Checked == false)
            {
                africantxt.Enabled = false;
                africantxt.Text = "0";
            }
        }
        private void africantxt_TextChanged(object sender, EventArgs e)
        {
            //africantxt.Text = "0";
            africantxt.Focus();
        }

        //AmericanCoffee
        private void americancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (americancoffee.Checked == true)
            {
                americantxt.Enabled = true;
            }
            if (americancoffee.Checked == false)
            {
                americantxt.Enabled = false;
                americantxt.Text = "0";
            }
        }
        private void americantxt_TextChanged(object sender, EventArgs e)
        {
            //americantxt.Text = "0";
            americantxt.Focus();
        }

        //IcedCappuccino
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (icedcappuccino.Checked == true)
            {
                icedcptxt.Enabled = true;
            }
            if (icedcappuccino.Checked == false)
            {
                icedcptxt.Enabled = false;
                icedcptxt.Text = "0";
            }
        }
        private void icedcptxt_TextChanged(object sender, EventArgs e)
        {
            //icedcptxt.Text = "0";
            icedcptxt.Focus();
        }

        //CoffeeCake
        private void coffeecake_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeecake.Checked == true)
            {
                coffeetxt.Enabled = true;
            }
            if (coffeecake.Checked == false)
            {
                coffeetxt.Enabled = false;
                coffeetxt.Text = "0";
            }
        }
        private void coffeetxt_TextChanged(object sender, EventArgs e)
        {
            //coffeetxt.Text = "0";
            coffeetxt.Focus();
        }

        //RedVelvetCake

        private void redvelvet_CheckedChanged(object sender, EventArgs e)
        {
            if (redvelvet.Checked == true)
            {
                redvelvettxt.Enabled = true;
            }
            if (redvelvet.Checked == false)
            {
                redvelvettxt.Enabled = false;
                redvelvettxt.Text = "0";
            }
        }
        private void redvelvettxt_TextChanged(object sender, EventArgs e)
        {
            //redvelvettxt.Text = "0";
            redvelvettxt.Focus();
        }


        //BlueCake
        private void bluecake_CheckedChanged(object sender, EventArgs e)
        {
            if (bluecake.Checked == true)
            {
                blutxt.Enabled = true;
            }
            if (bluecake.Checked == false)
            {
                blutxt.Enabled = false;
                blutxt.Text = "0";
            }
        }
        private void blutxt_TextChanged(object sender, EventArgs e)
        {
            //blutxt.Text = "0";
            blutxt.Focus();
        }

        //YellowCake

        private void yellowcake_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowcake.Checked == true)
            {
                yellowtxt.Enabled = true;
            }
            if (yellowcake.Checked == false)
            {
                yellowtxt.Enabled = false;
                yellowtxt.Text = "0";
            }
        }
        private void yellowtxt_TextChanged(object sender, EventArgs e)
        {
            //yellowtxt.Text = "0";
            yellowtxt.Focus();
        }

        //ChocolateCake
        private void chocolatecake_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolatecake.Checked == true)
            {
                chocolatetxt.Enabled = true;
            }
            if (chocolatecake.Checked == false)
            {
                chocolatetxt.Enabled = false;
                chocolatetxt.Text = "0";
            }
        }
        private void chocolatetxt_TextChanged(object sender, EventArgs e)
        {
            //chocolatetxt.Text = "0";
            chocolatetxt.Focus();
        }

        //CreamCake
        private void creamcake_CheckedChanged(object sender, EventArgs e)
        {
            if (creamcake.Checked == true)
            {
                creamtxt.Enabled = true;
            }
            if (creamcake.Checked == false)
            {
                creamtxt.Enabled = false;
                creamtxt.Text = "0";
            }
        }
        private void creamtxt_TextChanged(object sender, EventArgs e)
        {
            //creamtxt.Text = "0";
            creamtxt.Focus();
        }

        //CarrotCake
        private void carrotcake_CheckedChanged(object sender, EventArgs e)
        {
            if (carrotcake.Checked == true)
            {
                carrottxt.Enabled = true;
            }
            if (carrotcake.Checked == false)
            {
                carrottxt.Enabled = false;
                carrottxt.Text = "0";
            }
        }
        private void carrottxt_TextChanged(object sender, EventArgs e)
        {
            //carrottxt.Text = "0";
            carrottxt.Focus();
        }

        //WhiteCake
        private void whitecake_CheckedChanged(object sender, EventArgs e)
        {
            if (whitecake.Checked == true)
            {
                whitetxt.Enabled = true;
            }
            if (whitecake.Checked == false)
            {
                whitetxt.Enabled = false;
                whitetxt.Text = "0";
            }
        }
        private void whitetxt_TextChanged(object sender, EventArgs e)
        {
            //whitetxt.Text = "0";
            whitetxt.Focus();
        }



        //ReceiptOptions
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);

        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Clear();
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                receipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            
        }
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Cut();
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Paste();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(receipt.Text);


            }
        }



        //ReceiptButton
        private void button2_Click(object sender, EventArgs e)
        {
            receipt.Clear();

            receipt.AppendText(Environment.NewLine);
            receipt.AppendText("\t\t" + "H'Quick" + Environment.NewLine);
            receipt.AppendText("-------------------------------------------" + Environment.NewLine);
            receipt.AppendText("Latte \t\t\t" + lattetxt.Text + Environment.NewLine);
            receipt.AppendText("Expresso \t\t" + expressotxt.Text + Environment.NewLine);
            receipt.AppendText("Iced Latte \t\t" + icedlattetxt.Text + Environment.NewLine);
            receipt.AppendText("Vale Coffee \t\t" + valetxt.Text + Environment.NewLine);
            receipt.AppendText("Cappuccino \t\t" + cappuccinotxt.Text + Environment.NewLine);
            receipt.AppendText("African Coffee \t\t" + africantxt.Text + Environment.NewLine);
            receipt.AppendText("American Coffee \t" + americantxt.Text + Environment.NewLine);
            receipt.AppendText("Iced Cappuccino \t" + icedcptxt.Text + Environment.NewLine);


            receipt.AppendText("Coffee Cake \t\t" + coffeetxt.Text + Environment.NewLine);
            receipt.AppendText("Red Velvet Cake \t" + redvelvettxt.Text + Environment.NewLine);
            receipt.AppendText("Blue Cake  \t\t" + blutxt.Text + Environment.NewLine);
            receipt.AppendText("Yellow Cake \t\t" + yellowtxt.Text + Environment.NewLine);
            receipt.AppendText("Chocolate Cake \t" + chocolatetxt.Text + Environment.NewLine);
            receipt.AppendText("Cream Cake \t\t" + creamtxt.Text + Environment.NewLine);
            receipt.AppendText("Carrot Cake  \t\t" + carrottxt.Text + Environment.NewLine);
            receipt.AppendText("White Cake \t\t" + whitetxt.Text + Environment.NewLine);

            receipt.AppendText("--------------------------------------------"  + Environment.NewLine);
            receipt.AppendText("Service Charge \t\t" + servicetxt.Text + Environment.NewLine);
            receipt.AppendText("--------------------------------------------" + Environment.NewLine);

            receipt.AppendText("Tax \t\t" + taxtxt.Text + Environment.NewLine);
            receipt.AppendText("Sub Total \t\t" + subtotaltxt.Text + Environment.NewLine);
            receipt.AppendText("Total \t\t" + totaltxt.Text + Environment.NewLine);

            receipt.AppendText("-------------------------------------------" + Environment.NewLine);

            receipt.AppendText(lblTime.Text + "\t\t" + lblDate.Text);
        }



        //TotalButton
        private void btntotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;

            double latt, expres, ilatte, vCoffee, cappuc, aCoffee, amCoffee, iCappuccino;
            double cCake, rVelvet, bCake, yCake, choCake, creCake, carCake, wCake;

            //Coffee
            latt = 1.20; expres = 1.29; ilatte = 1.50; vCoffee = 1.45; cappuc = 1.70; aCoffee = 1.50; amCoffee = 1.45; iCappuccino = 1.70;
            double latte_Coff = Convert.ToDouble(lattetxt.Text);
            double expres_Coff = Convert.ToDouble(expressotxt.Text);
            double ilatte_Coff = Convert.ToDouble(icedlattetxt.Text);
            double vCoffee_Coff = Convert.ToDouble(valetxt.Text);
            double cappuc_Coff = Convert.ToDouble(cappuccinotxt.Text);
            double aCoffee_Coff = Convert.ToDouble(africantxt.Text);
            double amCoffee_Coff = Convert.ToDouble(americantxt.Text);
            double iCappuccino_Coff = Convert.ToDouble(icedcptxt.Text);

            //Cakes
            cCake = 1.10; rVelvet = 1.70; bCake = 2.0; yCake = 2.5; choCake = 1.85; creCake = 1.25; carCake = 1.42; wCake = 2.10;
            double cCake_Cake = Convert.ToDouble(coffeetxt.Text);
            double rVelvet_Cake = Convert.ToDouble(redvelvettxt.Text);
            double bCake_Cake = Convert.ToDouble(blutxt.Text);
            double yCake_Cake = Convert.ToDouble(yellowtxt.Text);
            double choCake_Cake = Convert.ToDouble(chocolatetxt.Text);
            double creCake_Cake = Convert.ToDouble(creamtxt.Text);
            double carCake_Cake = Convert.ToDouble(carrottxt.Text);
            double wCake_Cake = Convert.ToDouble(whitetxt.Text);


            Cafe eat = new Cafe(latte_Coff, expres_Coff, ilatte_Coff, vCoffee_Coff, cappuc_Coff, aCoffee_Coff, amCoffee_Coff, iCappuccino_Coff,
                cCake_Cake, rVelvet_Cake, bCake_Cake, yCake_Cake, choCake_Cake, creCake_Cake, carCake_Cake, wCake_Cake);

            double cost_of_drinks = (latte_Coff * latt) + (expres_Coff * expres) + (ilatte_Coff * ilatte) + (vCoffee_Coff * vCoffee) +
                (cappuc_Coff * cappuc) + (aCoffee_Coff * aCoffee) + (amCoffee_Coff * amCoffee) + (iCappuccino_Coff * iCappuccino);
            drinkstxt.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (cCake_Cake * cCake) + (rVelvet_Cake * rVelvet) + (bCake_Cake * bCake) + (yCake_Cake * yCake) +
                (choCake_Cake * choCake) + (creCake_Cake * creCake) + (carCake_Cake * carCake) + (wCake_Cake * wCake);
            cakestxt.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(servicetxt.Text);


            subtotaltxt.Text = Convert.ToString(cost_of_drinks + cost_of_cakes + service_charge);
            taxtxt.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100);
            double itax = Convert.ToDouble(taxtxt.Text);
            totaltxt.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + itax + service_charge);


            cakestxt.Text = String.Format("{0:C}", cost_of_cakes);
            drinkstxt.Text = String.Format("{0:C}", cost_of_drinks);
            servicetxt.Text = String.Format("{0:C}", service_charge);
            subtotaltxt.Text = String.Format("{0:C}", (cost_of_cakes + cost_of_drinks + service_charge));
            taxtxt.Text = String.Format("{0:C}", itax);
            totaltxt.Text = String.Format("{0:C}", (cost_of_drinks + cost_of_cakes + service_charge + itax));

        }
    }
}
