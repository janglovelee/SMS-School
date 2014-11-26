using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCenterSMS.View;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views.CongCu;

namespace SchoolCenterSMS.Presenter
{
    public class CongCuPresenter : BasePresenter
    {
        #region Constants
        public const int BLACK_LIST = 0;
        public const int AUTO_REPLY = 1;
        #endregion

        #region Enums
        #endregion

        #region Fields
        private int subMenuIndex = -1;

        private BlackListView _blackListView;
        private AutoReplyView _autoReplyView;
        #endregion

        #region Properties
        public BlackListView BlackListView
        {
            get
            {
                if (_blackListView == null)
                {
                    this._blackListView = new BlackListView();
                }
                return this._blackListView;
            }
        }
        public AutoReplyView AutoReplyView
        {
            get
            {
                if (_autoReplyView == null)
                {
                    _autoReplyView = new AutoReplyView();
                }
                return _autoReplyView;
            }
        }

        #endregion

        #region Constructors
        public CongCuPresenter(MainForm form)
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
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.BlackList, "Danh sách đen"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.AutoReply, "Trả lời tự động"));
            this.mainForm.SubMenu_ItemClick = SubMenu_ItemClick;
            if (subMenuIndex == -1)//Lan dau tien load sub menu
                SubMenu_ItemClick(BLACK_LIST);//view mac dinh
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
                case BLACK_LIST:
                    this.mainForm.DisplayView(BlackListView);
                    break;
                case AUTO_REPLY:
                    this.mainForm.DisplayView(AutoReplyView);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
