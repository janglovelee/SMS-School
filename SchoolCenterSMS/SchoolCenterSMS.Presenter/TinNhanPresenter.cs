using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCenterSMS.View;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views.TinNhan;

namespace SchoolCenterSMS.Presenter
{
    public class TinNhanPresenter : BasePresenter
    {
        #region Constants
        public const int INBOX = 0;
        public const int OUTBOX = 1;
        public const int SENT = 2;
        public const int ERROR = 3;
        #endregion

        #region Enums
        #endregion

        #region Fields
        private int subMenuIndex = -1;

        private InboxView _inboxView;
        private OutboxView _outboxView;
        private SentView _sentView;
        private ErrorView _errorView;
        #endregion

        #region Properties
        public InboxView InboxView
        {
            get
            {
                if (_inboxView == null)
                {
                    this._inboxView = new InboxView();
                }
                return this._inboxView;
            }
        }
        public OutboxView OutboxView
        {
            get
            {
                if (_outboxView == null)
                {
                    _outboxView = new OutboxView();
                }
                return _outboxView;
            }
        }

        public SentView SentView
        {
            get
            {
                if (_sentView == null)
                {
                    this._sentView = new SentView();
                }
                return this._sentView;
            }
        }
        public ErrorView ErrorView
        {
            get
            {
                if (_errorView == null)
                {
                    _errorView = new ErrorView();
                }
                return _errorView;
            }
        }

        #endregion

        #region Constructors
        public TinNhanPresenter(MainForm form)
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
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.Inbox, "Hộp thư đến"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.Outbox, "Hộp thư đi"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.Sent, "Tin đã gửi"));
            this.mainForm.AddSubMenuItem(UIHelper.CreateMenuItem(Properties.Resources.Error, "Thư bị lỗi"));
            this.mainForm.SubMenu_ItemClick = SubMenu_ItemClick;
            if (subMenuIndex == -1)//Lan dau tien load sub menu
                SubMenu_ItemClick(INBOX);//view mac dinh
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
                case INBOX:
                    this.mainForm.DisplayView(InboxView);
                    break;
                case OUTBOX:
                    this.mainForm.DisplayView(OutboxView);
                    break;
                case SENT:
                    this.mainForm.DisplayView(SentView);
                    break;
                case ERROR:
                    this.mainForm.DisplayView(ErrorView);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
