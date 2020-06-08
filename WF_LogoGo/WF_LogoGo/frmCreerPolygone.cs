/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : frmCreer.cs
 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public partial class frmCreerPolygone : Form
    {
        private PointF[] _trace;
        private List<PointF> _pointsATracer;
        private Polygone NouveauPolygone;

        public PointF[] Trace { get => _trace; private set => _trace = value; }

        public frmCreerPolygone(Polygone p)
        {
            InitializeComponent();
            _pointsATracer = new List<PointF>();
            NouveauPolygone = p;
        }

        /// <summary>
        /// Appelé lorsque l'utilisateur "clique" sur la PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxPolygone_MouseDown(object sender, MouseEventArgs e)
        {
            btnOK.Enabled = true;
            _pointsATracer.Add(new PointF(e.X, e.Y));
        }

        /// <summary>
        /// À l'appui du bouton OK, ajoute les points au tableau Trace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Trace = new PointF[_pointsATracer.Count];
            int compteur = 0;
            foreach (PointF unPointF in _pointsATracer)
            {
                Trace[compteur++] = new PointF(unPointF.X - _pointsATracer[0].X, unPointF.Y - _pointsATracer[0].Y);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }


    }
}
