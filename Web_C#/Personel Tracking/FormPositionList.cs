using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.DTO;

namespace Personel_Tracking {
    public partial class FormPositionList : Form {

        List<PositionDTO> positionList = new List<PositionDTO>();

        public FormPositionList() {
            InitializeComponent();
        }

        void FillGrid() {
            positionList = PositionBLL.GetPositions();
            dataGridView1.DataSource = positionList;
        }

        // ON POSITION LIST LOAD
        private void FormPositionList_Load(object sender, EventArgs e) {
            FillGrid();
            dataGridView1.Columns[1].Visible = false; // Hide positionID
            dataGridView1.Columns[3].Visible = false; // Hide departmentID
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[2].HeaderText = "Position Name";
        }

        // ADD NEW POSITION
        private void buttonNew_Click(object sender, EventArgs e) {
            FormPosition formPosition = new FormPosition();
            this.Hide();
            formPosition.ShowDialog();
            this.Visible = true; // Shows FormPositionList when FormPosition closed
            FillGrid();
        }

        // UPDATE POSITION
        private void buttonUpdate_Click(object sender, EventArgs e) {
            FormPosition formPosition = new FormPosition();
            this.Hide();
            formPosition.ShowDialog();
            this.Visible = true; // Shows FormPositionList when FormPosition closed
        }

        // CLOSE POSITION LIST FORM
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
