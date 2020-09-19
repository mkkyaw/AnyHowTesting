using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anyhow.Awesome
{
    class CodeSnippetExamples
    {

        public CodeSnippetExamples(string test)
        {
            try
            {
                var aa = "";
            }
            catch (Exception)
            {

                throw;
            }

            try
            {

            }
            finally
            {


            }
            for (int i = 0; i < 10; i++)
            {
            i++;
            }

            var names = new List<string>();
            
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        public string FirstName { get; set; }
        private string  lastName;

        public string  LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
    }
}
