using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro {
    public partial class PomodoroForm : Form {
        public PomodoroForm() {
            InitializeComponent();
            pomodoro = new Pomodoro(tbRad.Text, tbOdmor.Text);
            
            // AzurirajBrojSekundi(tbRad.Text);
            AzurirajPrikaz();
        }

        private void btnStartStop_Click(object sender, EventArgs e) {
            #region hrpakoda
            /*if( tmrOdbrojavanje.Enabled) {
                tmrOdbrojavanje.Enabled = false;
            } else {
                tmrOdbrojavanje.Enabled = true;
            }*/
            #endregion hrpakoda
            tmrOdbrojavanje.Enabled = !tmrOdbrojavanje.Enabled;
        }

        private void tmrOdbrojavanje_Tick(object sender, EventArgs e) {
            pomodoro.Tick();
            #region hrpakomentara
            /*if( trenutanBrojSekundi == 0) {
                if( radPokrenut) {
                    AzurirajBrojSekundi(tbOdmor.Text);
                } else {
                    AzurirajBrojSekundi(tbRad.Text);      
                }
                radPokrenut = !radPokrenut;
            }
            trenutanBrojSekundi--;*/

            // lblVrijeme.Text = trenutanBrojSekundi.ToString();
            // lblVrijeme.Text = (trenutanBrojSekundi / 60).ToString() + ":" + (trenutanBrojSekundi % 60).ToString();
            #endregion hrpakomentara
            AzurirajPrikaz();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            tmrOdbrojavanje.Enabled = false;
            pomodoro = new Pomodoro(tbRad.Text, tbOdmor.Text); // Stvara se novi Pomodoro objekt (Garbage collector izbriše instace istalih objekata)
            // AzurirajBrojSekundi(tbRad.Text);
            AzurirajPrikaz();
        }

        /*private void AzurirajBrojSekundi(string brojMinuta) {
            trenutanBrojSekundi = int.Parse(brojMinuta) * 60;
        }*/

        private void AzurirajPrikaz() {
            if( pomodoro.RadPokrenut) {
                lblPrikazRad.Text = "RAD";
            } else {
                lblPrikazRad.Text = "ODMOR";
            }
            lblVrijeme.Text = pomodoro.ToString();   
        }

        // private bool radPokrenut;
        // private int trenutanBrojSekundi;
        Pomodoro pomodoro; // null na početku

    }
}
