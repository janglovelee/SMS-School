using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCenterSMS.View.Forms;
using SchoolCenterSMS.View.Views;

namespace SchoolCenterSMS.Presenter
{
    public class BasePresenter
    {
        #region Fields
        protected BaseView activeView;
        protected MainForm mainForm;
        #endregion

        #region Constructors
        public BasePresenter(MainForm form)
        {
            this.mainForm = form;
            Initial();
        }
        #endregion

        #region Private Methods
        #endregion

        #region Propected Methods
        protected virtual void Initial()
        {
            Console.WriteLine("BasePresenter.Initial()");
        }
        protected virtual void CreateSubMenuItems()
        {
            Console.WriteLine("BasePresenter.CreateSubMenuItems()");
            this.mainForm.ResetSubMenu();
        }
        #endregion

        #region Public Methods
        public virtual void Active()
        {
            Console.WriteLine("BasePresenter.Active()");
            CreateSubMenuItems();
        }
        #endregion
    }
}
