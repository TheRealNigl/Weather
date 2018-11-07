using Accord.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Model
{
    internal abstract class Weather
    {
        protected string Name
        {
            get;
            set;
        }

        public Weather(string name)
        {
            Name = name;
        }

        public void MeasureWeather()
        {
            //// 5a9276ef806e1ba610589d75b48a53d7
            //// http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=
            //try
            //{
            //    var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            //    var response = await client.GetAsync(uri);
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var content = await response.Content.ReadAsStringAsync();
            //        string item = JsonConvert.DeserializeObject(content);
            //    }
            //    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
            //    var location = await Geolocation.GetLastKnownLocationAsync();

            //    if (location != null)
            //    {
            //        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
            //    }
            //}
            //catch (FeatureNotSupportedException fnsEx)
            //{
            //    // Handle not supported on device exception
            //}
            //catch (PermissionException pEx)
            //{
            //    // Handle permission exception
            //}
            //catch (Exception ex)
            //{
            //    // Unable to get location
            //}
        }
    }
}
