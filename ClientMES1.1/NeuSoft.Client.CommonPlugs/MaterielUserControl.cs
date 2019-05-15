using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NeuSoft.ServiceInterface.Api;
using NeuSoft.ServcieInterface.InterfaceAPI;
using NeuSoft.Client.InterfaceDTO.MaterielArea;
using Dos.ORM;
using System.Web.Script.Serialization;

namespace NeuSoft.Client.CommonPlugs
{
    public partial class MaterielUserControl : UserControl
    {
        public MaterielUserControl()
        {
            InitializeComponent();
            this.Load += MaterielUserControl_Load;
        }

        private void MaterielUserControl_Load(object sender, EventArgs e)
        {
            IInterfaceFactory interfaceFactory = SystemInterface.CreateInterfaceIntances();
            WhereClipBuilder whereClip = new WhereClipBuilder();
            whereClip.And(MaterielInfoDTO._.Code != null || MaterielInfoDTO._.Code != "");
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            IList<MaterielInfoDTO> listForMaterielInfoDTO = interfaceFactory.aideIMaterielInfoInterface.GetMaterielInfoDTOPageList(2, 5, whereClip, "MaterielInfoGuid", true);
            IList<MaterielTypeDTO> listForMaterielTypeDTO = interfaceFactory.aideIMaterielTypeInterface.GetMaterielTypeDTOAllList();
            IList<MeasurementUnitDTO> listForMeasurementUnitDTO = interfaceFactory.aideIMeasurementUnitInterface.GetMeasurementUnitAllList();
            dataGridView1.DataSource = javaScriptSerializer.Deserialize<IList<MaterielInfoDTO>>(javaScriptSerializer.Serialize(listForMaterielInfoDTO));
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = javaScriptSerializer.Deserialize<IList<MaterielTypeDTO>>(javaScriptSerializer.Serialize(listForMaterielTypeDTO));
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = javaScriptSerializer.Deserialize<IList<MeasurementUnitDTO>>(javaScriptSerializer.Serialize(listForMeasurementUnitDTO));
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
 

        }



    }
}
