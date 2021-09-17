/*Project:Testing Facebook loginpage using data driven framework
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */


using log4net;
using NUnit.Framework;

namespace DataDrivenTest_FaceBook
{
   
    public class Tests : Base.BaseClass
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));
        [Test]
        public void Test__LoginPage()
        {
            log.Info("Entering Test1");
            Actions.DoAction.Assert_Titleof_Webpage();
            Actions.DoAction.Login_into_FaceBook();
        }
        [Test]
      public void SENDkeys()
        {
            Actions.KeyboardEvents.PerformKeyboardActions();
        }
    }
}