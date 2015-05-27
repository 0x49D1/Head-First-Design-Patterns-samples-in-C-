namespace ObserverSample.More_Proper
{
    public interface IObserver
    {
        /// <summary>
        /// Method needed by all the observers in our Weather station for getting the notification
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void Update(float temp, float humidity, float pressure);
    }
}