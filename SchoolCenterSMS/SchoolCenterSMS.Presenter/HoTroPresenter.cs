using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCenterSMS.View;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views.HoTro;

namespace SchoolCenterSMS.Presenter
{
    public class HoTroPresenter : BasePresenter
    {
        #region Constants
        public const int GIOI_THIEU = 0;
        public const int BAN_QUYEN = 1;
        public const int THIET_BI_HO_TRO = 2;
        #endregion

        #region Enums
        #endregion

        #region Fields
        private int subMenuIndex = -1;

        private GioiThieuView _gioiThieuView;
        private BanQuyenView _banQuyenView;
        private ThietBiHoTroView _thietBiHoTroView;
        #endregion

        #region Properties
        public GioiThieuView GioiThieuView
        {
            get
            {
                if (_gioiThieuView == null)
                {
                    this._gioiThieuView = new GioiThieuView();
                }
                return this._gioiThieuView;
            }
        }
        public BanQuyenView BanQuyenView
        {
            get
            {
                if (_banQuyenView == null)
                {
                    _banQuyenView = new BanQuyenView();
                }
                return _banQuyenView;
            }
        }

        public ThietBiHoTroView ThietBiHoTroView
        {
            get
            {
                if (_thietBiHoTroView == null)
                {
                    this._thietBiHoTroView = new ThietBiHoTroView();
                }
                return this._thietBiHoTroView;
            }
        }

        #endregion

        #region Constructors
        public HoTroPresenter(MainForm form)
            : base(form)
        {
        }
        #endregion

        #region Private Methods

        #endregion

        #region Protected Methods
        protected override void Initial()
        {
            base.Initial();
        }
        protected override void CreateSubMenuItems()
        {
            base.CreateSubMenuItems();
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.GioiThieu, "Giới thiệu chương trình"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.BanQuyen, "Bản quyền"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.ThietBiHoTro, "Thiết bị hỗ trợ"));
            this.mainForm.SubMenu_ItemClick = SubMenu_ItemClick;
            if (subMenuIndex == -1)//Lan dau tien load sub menu
                SubMenu_ItemClick(GIOI_THIEU);//view mac dinh
            else
                SubMenu_ItemClick(subMenuIndex);//Luu lai trang thai cu cua sub menu
        }
        #endregion

        #region Public Methods
        public override void Active()
        {
            base.Active();
        }

        #endregion

        #region Events
        private void SubMenu_ItemClick(int index)
        {
            this.subMenuIndex = index;
            switch (index)
            {
                case GIOI_THIEU:
                    this.mainForm.DisplayView(GioiThieuView);
                    break;
                case BAN_QUYEN:
                    this.mainForm.DisplayView(BanQuyenView);
                    break;
                case THIET_BI_HO_TRO:
                    this.mainForm.DisplayView(ThietBiHoTroView);
                    break;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
