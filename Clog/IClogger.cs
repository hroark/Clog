namespace Clog
{
    internal interface ICLogger
    {
        void Subscribe(CLogger logger);

        void Unsubscribe(CLogger logger);
    }
}