namespace ThunderLib.Monomod
{
    using System;
    using System.Reflection;

    using MonoMod.Cil;
    using MonoMod.RuntimeDetour.HookGen;

    public abstract class MethodIL
    {
        protected abstract MethodBase method { get; }
        public void Add_IL(ILContext.Manipulator hook) => HookEndpointManager.Modify(this.method, hook);
        public void Remove_IL(ILContext.Manipulator hook) => HookEndpointManager.Unmodify(this.method, hook);
        public event ILContext.Manipulator IL
        {
            add => this.Add_IL(value);
            remove => this.Remove_IL(value);
        }
    }


}
