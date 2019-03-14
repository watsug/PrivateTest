namespace PrivateTest
{
    public
#if DEBUG
        partial
#endif
        class Class1
    {
        private bool AlwaysTrue()
        {
            return true;
        }
    }
}