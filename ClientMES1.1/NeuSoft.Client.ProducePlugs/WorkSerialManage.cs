using NeuSoft.Client.Contract;
using NeuSoft.Client.InterfaceDTO;
using NeuSoft.Client.InterfaceDTO.IME;
using NeuSoft.ServiceInterface.Api;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.IME;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace NeuSoft.Client.ProducePlugs
{
    [Plugin("a9a36d17-85bc-4b0d-b743-45e4a501ce21", "生产工单", AsVisual = true, GroupId = 1, Power = 0, Weight = 1)]
    public partial class WorkSerialManage : UserControl, IPlugin
    {
        public WorkSerialManage()
        {
            InitializeComponent();

            //绑定列
            PropertyInfo[] sourcesPropertyInfoArray = typeof(WorkSerialManagerDTO).GetProperties();
            foreach (var item in sourcesPropertyInfoArray)
            {
                this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    ValueType = item.PropertyType,
                    HeaderText = item.Name,
                    DataPropertyName = item.Name
                });
            }
        }

        public bool Block(PluginMessage message)
        {
            return false;
        }

        IWorkSerialManagerInterface @interface = SystemInterface.CreateInterfaceIntances().workSerialManagerInterface;

        string GidA = Guid.NewGuid().ToString();
        string GidB = Guid.NewGuid().ToString();
        string GidC = Guid.NewGuid().ToString();

        #region 事件

        private void btnBatchCreate_Click(object sender, System.EventArgs e)
        {
            List<WorkSerialManagerDTO> list = new List<WorkSerialManagerDTO>();
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidA,
                SERIAL_CODE = "A",
                SERIAL_TYPE = "A",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidB,
                SERIAL_CODE = "B",
                SERIAL_TYPE = "B",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            RtnEntity<int> rtnEntity = @interface.BatchCreate(list);
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            RtnEntity<int> rtnEntity = @interface.Create(new WorkSerialManagerDTO
            {
                GID = GidC,
                SERIAL_CODE = "C",
                SERIAL_TYPE = "C",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnGetAllList_Click(object sender, System.EventArgs e)
        {
            var list = @interface.GetAllList().ToList();
            this.dataGridView1.DataSource = list;
        }

        private void btnGetListByExpr_Click(object sender, System.EventArgs e)
        {
            IList<WorkSerialManagerDTO> list = @interface.GetListByExpr(x => x.CREATE_BY == "Test").ToList();
            this.dataGridView1.DataSource = list;
        }

        private void btnDeleteList_Click(object sender, System.EventArgs e)
        {
            List<WorkSerialManagerDTO> list = new List<WorkSerialManagerDTO>();
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidA,
                SERIAL_CODE = "A",
                SERIAL_TYPE = "A",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidB,
                SERIAL_CODE = "A",//注意这里出现了错误的字段,会更新上去
                SERIAL_TYPE = "B",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            RtnEntity<int> rtnEntity = @interface.DeleteList(list);
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            RtnEntity<int> rtnEntity = @interface.Delete(new WorkSerialManagerDTO
            {
                GID = GidC,           //注意这里的主键被屏蔽时候无法进行更新，则通过实体进行更新操作需要依赖主键进行操作
                SERIAL_CODE = "C",
                SERIAL_TYPE = "D",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "Test",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnDeleteExpr_Click(object sender, System.EventArgs e)
        {
            RtnEntity<int> rtnEntity = @interface.DeleteByExpr(x => x.CREATE_BY == "Test");
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnUpdateList_Click(object sender, System.EventArgs e)
        {
            List<WorkSerialManagerDTO> list = new List<WorkSerialManagerDTO>();
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidA,
                SERIAL_CODE = "A",
                SERIAL_TYPE = "A",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "AAA",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            list.Add(new WorkSerialManagerDTO
            {
                GID = GidB,
                SERIAL_CODE = "B",
                SERIAL_TYPE = "B",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "BBB",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            RtnEntity<int> rtnEntity = @interface.UpdateList(list);
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            RtnEntity<int> rtnEntity = @interface.Update(new WorkSerialManagerDTO
            {
                GID = GidC,
                SERIAL_CODE = "C",
                SERIAL_TYPE = "C",
                WORK_ORDER_GID = Guid.NewGuid().ToString(),
                CREATE_BY = "Test",
                CREATE_TIME = DateTime.Now,
                UPDATE_BY = "CCC",
                UPDATE_TIME = DateTime.Now,
                IS_DELETE = 0,
                IS_ACTIVE = 0
            });
            if (rtnEntity.IsSuccess)
                MessageBox.Show("成功");
            else
                MessageBox.Show(rtnEntity.ErrorMsg);
        }

        private void btnGetModelByGid_Click(object sender, System.EventArgs e)
        {
            WorkSerialManagerDTO rtnEntity = @interface.GetModelByGid("e30574f2b93640279109d0ececa033dd");
            this.dataGridView1.DataSource = new List<WorkSerialManagerDTO> { rtnEntity };
        }

        private void btnGetPageList_Click(object sender, System.EventArgs e)
        {
            List<WorkSerialManagerDTO> list = @interface.GetPageList(1, 2, x => x.CREATE_BY == "Test", "CREATE_BY", false).ToList();
            this.dataGridView1.DataSource = list;
        }

        private void btnGetCount_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(@interface.GetCount(x => x.CREATE_BY == "Test").ToString());
        }

        #endregion
    }
}
