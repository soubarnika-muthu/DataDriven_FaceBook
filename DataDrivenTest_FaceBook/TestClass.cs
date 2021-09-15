/*Project:Testing Facebook loginpage using data driven framework
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */

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