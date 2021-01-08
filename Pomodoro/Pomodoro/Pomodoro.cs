using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro {
    class Pomodoro {

        public Pomodoro(string brojMinutaRad, string brojMinutaOdmor) {
            this.brojMinutaRad = brojMinutaRad;
            this.brojMinutaOdmor = brojMinutaOdmor;
            TrenutanBrojSekundi = int.Parse(brojMinutaRad) * 60;
            RadPokrenut = true;
        }

        public override string ToString() {
            return string.Format("{0:D2}:{1:D2}", TrenutanBrojSekundi / 60, TrenutanBrojSekundi % 60);
        }

        public void Tick() {
            if (TrenutanBrojSekundi == 0) {
                if (RadPokrenut) {
                    TrenutanBrojSekundi = int.Parse(brojMinutaOdmor) * 60;
                    //AzurirajBrojSekundi(tbOdmor.Text);
                }
                else {
                    TrenutanBrojSekundi = int.Parse(brojMinutaRad) * 60;
                    //AzurirajBrojSekundi(tbRad.Text);
                }
                RadPokrenut = !RadPokrenut;
            }
            TrenutanBrojSekundi--;
        }

        private string brojMinutaRad;
        private string brojMinutaOdmor;
        public int TrenutanBrojSekundi { get; set; }
        public bool RadPokrenut { get; set; }
    }
}
