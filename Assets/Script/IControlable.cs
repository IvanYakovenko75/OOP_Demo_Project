public interface IControlable
    // interface object cannot be created. It has no implementation.
    // Needed to manage several different objects that use common methods.
    //An interface is a managed abstraction used to invoke common methods on non-inherited objects.
    //abstraction
    {
        void Fly();
        void Shot();
    }
