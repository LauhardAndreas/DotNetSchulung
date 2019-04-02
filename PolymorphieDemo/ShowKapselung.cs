using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolymorphieDemo
{
    public class ShowKapselung
    {
        public void TestA()
        {

        }
        private void TestB()
        {

        }
        internal void Test()
        {

        }
    }

    public abstract class Parent
    {
        public Parent()
        {

        }

        protected void ParentMethodA()
        {

        }

        private void ParentMethodB()
        {

        }
        public void ParentMethodC()
        {

        }
        public abstract void ParentAbstractMethodD();

        public virtual void ParentVirtualMethodE()
        {

        }
    }

   
    public class Parent2
    {

    }

    public class Child : Parent, IParent2
    {
        public Child()
        {
            ParentMethodA();
            ParentMethodC();
        }

        public new void ParentMethodA()  //modifizierer von Parent überschrieben
        {

        }

        public override void ParentAbstractMethodD()
        {

        }

        public override void ParentVirtualMethodE()
        {
            base.ParentVirtualMethodE();
            ParentMethodA();
            //eigene Logik..
        }



    }

}
