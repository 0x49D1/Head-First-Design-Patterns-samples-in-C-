namespace AdapterSample
{
    class TurkeyAdapter : IDuck
    {
        public ITurkey turkey ;

        public void Quarck()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}
