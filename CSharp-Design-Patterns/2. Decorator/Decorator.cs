using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Design_Patterns._2._Decorator
{
    // Component interface
    public interface IComponent
    {
        void Operation();
    }

    // Concrete component
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    // Decorator base class
    public abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }

    // Concrete decorator
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private void AddedBehavior()
        {
            Console.WriteLine("Added behavior by ConcreteDecorator");
        }
    }
}
