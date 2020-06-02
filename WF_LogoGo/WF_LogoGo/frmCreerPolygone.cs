using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void pbxPolygone_MouseDown(object sender, MouseEventArgs e)
        {
            btnOK.Enabled = true;
            _pointsATracer.Add(new PointF(e.X, e.Y));
        }

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
