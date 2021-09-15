
using NUnit.Framework;

namespace DataDrivenTest_FaceBook
{
    public class Tests : Base.BaseClass
    {
        [Test]
        public void Test__LoginPage()
        {
           
            Actions.DoAction.Assert_Titleof_Webpage();
            Actions.DoAction.Login_into_FaceBook();
        }
      
    }
}