using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darkest_Dungeon_Companion
{
    public partial class FrmDarkest : Form
    {
        public FrmDarkest()
        {
            InitializeComponent();
        }

        private void FrmDarkest_Load(object sender, EventArgs e)
        {
            //read image
            Bitmap bmpDarkLogo = new Bitmap("C:\\Images\\DarkCompLogo.png");
            Bitmap bmpRuinsShortProv = new Bitmap("C:\\Images\\ruinsShortProv.JPG");
            Bitmap bmpCoinLogo = new Bitmap("C:\\Images\\coin.png");

            //load image in picturebox
            picBoxDarkLogo.Image = bmpDarkLogo;
            picBoxRSP.Image = bmpRuinsShortProv;
            picBoxCoin.Image = bmpCoinLogo;

            //write image
            bmpDarkLogo.Save("C:\\Images\\OutputDarkLogo.png");
            bmpRuinsShortProv.Save("C:\\Images\\OutputRuinsShortProv");
            bmpCoinLogo.Save("C:\\Images\\OutputCoin");

            //Load area


        }

        //Set Booleans to determine which buttons have been click.
        private bool btnRuinsWasClicked = true;
        private bool btnWarrensWasClicked = false;
        private bool btnWealdWasClicked = false;
        private bool btnCoveWasClicked = false;

        private bool btnShortWasClicked = true;
        private bool btnMediumWasClicked = false;
        private bool btnLongWasClicked = false;

        //The following click events will check to see which button was clicked, and then based on that, change the color to blue so that
        //the use can see which option they have chosen. Then it will adjust the other buttons back to their default colors.

        
        private void btnRuins_Click(object sender, EventArgs e)
        {
            btnRuinsWasClicked = true;
            btnWarrensWasClicked = false;
            btnWealdWasClicked = false;
            btnCoveWasClicked = false;

            if(btnRuinsWasClicked == true && btnWarrensWasClicked == false && btnWealdWasClicked == false && btnCoveWasClicked == false)
            {
                btnRuins.ForeColor = System.Drawing.Color.RoyalBlue;
                btnWeald.ForeColor = System.Drawing.Color.Black;
                btnWarrens.ForeColor = System.Drawing.Color.Black;
                btnCove.ForeColor = System.Drawing.Color.Black;

                lblEffect1.Text = "Blight";
                lblSubEffect1.Text = "low resist";

                lblEffect2.Text = "Crusader";
                lblSubEffect2.Text = "extra DMG vs. Unholy";

                lblEffect3.Text = "Direct Damage";
                lblSubEffect3.Text = "Few high PROT enemies";

                lblIneffect1.Text = "Bleeds";
                lblSubInEffect1.Text = "high resist";

                lblCostOutP.Text = "2,850";

                lblDanger1.Text = "Bone spearman";
                lblSubDanger1.Text = "at low ranks";

                lblDanger2.Text = "Stress dealers";
                lblSubDanger2.Text = "Bone Courtier, Cultist Acolyte and Madman";

                lblDanger3.Text = "Books and bookshelves";
                lblSubDanger3.Text = "High risk of bad outcome";
            }
            else
            {
                btnRuinsWasClicked = false;
            }
        }

        private void btnWeald_Click(object sender, EventArgs e)
        {
            btnWealdWasClicked = true;
            btnRuinsWasClicked = false;
            btnWarrensWasClicked = false;
            btnCoveWasClicked = false;

            if(btnWealdWasClicked == true && btnRuinsWasClicked == false && btnWarrensWasClicked == false && btnCoveWasClicked == false)
            {
                btnWeald.ForeColor = System.Drawing.Color.RoyalBlue;
                btnRuins.ForeColor = System.Drawing.Color.Black;
                btnWarrens.ForeColor = System.Drawing.Color.Black;
                btnCove.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnWealdWasClicked = false;
            }
        }

        private void btnWarrens_Click(object sender, EventArgs e)
        {
            btnWarrensWasClicked = true;
            btnRuinsWasClicked = false;
            btnWealdWasClicked = false;
            btnCoveWasClicked = false;

            if(btnWarrensWasClicked == true && btnRuinsWasClicked == false && btnWealdWasClicked == false && btnCoveWasClicked == false)
            {
                btnWarrens.ForeColor = System.Drawing.Color.RoyalBlue;
                btnRuins.ForeColor = System.Drawing.Color.Black;
                btnWeald.ForeColor = System.Drawing.Color.Black;
                btnCove.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnWarrensWasClicked = false;
            }
        }

        private void btnCove_Click(object sender, EventArgs e)
        {
            btnCoveWasClicked = true;
            btnRuinsWasClicked = false;
            btnWealdWasClicked = false;
            btnWarrensWasClicked = false;

            if (btnCoveWasClicked == true && btnRuinsWasClicked == false && btnWealdWasClicked == false && btnWarrensWasClicked == false)
            {
                btnCove.ForeColor = System.Drawing.Color.RoyalBlue;
                btnRuins.ForeColor = System.Drawing.Color.Black;
                btnWarrens.ForeColor = System.Drawing.Color.Black;
                btnWeald.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnCoveWasClicked = false;
            }

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            btnShortWasClicked = true;
            btnMediumWasClicked = false;
            btnLongWasClicked = false;

            if(btnShortWasClicked == true && btnMediumWasClicked == false && btnLongWasClicked == false)
            {
                btnShort.ForeColor = System.Drawing.Color.RoyalBlue;
                btnMedium.ForeColor = System.Drawing.Color.Black;
                btnLong.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnShortWasClicked = false;
            }
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            btnMediumWasClicked = true;
            btnShortWasClicked = false;
            btnLongWasClicked = false;

            if (btnMediumWasClicked == true && btnShortWasClicked == false && btnLongWasClicked == false)
            {
                btnMedium.ForeColor = System.Drawing.Color.RoyalBlue;
                btnShort.ForeColor = System.Drawing.Color.Black;
                btnLong.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnMediumWasClicked = false;
            }
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            btnLongWasClicked = true;
            btnShortWasClicked = false;
            btnMediumWasClicked = false;

            if (btnLongWasClicked == true && btnMediumWasClicked == false && btnShortWasClicked == false)
            {
                btnLong.ForeColor = System.Drawing.Color.RoyalBlue;
                btnShort.ForeColor = System.Drawing.Color.Black;
                btnMedium.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                btnLongWasClicked = false;
            }
        }
    }
}
