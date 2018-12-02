using Newtonsoft.Json;
using SpaceLaunches.Entities;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SpaceLaunches.Repositories
{
    public class LaunchRepository
    {
        HttpClient client = new HttpClient();

        public LaunchRepository()
        {
            client.BaseAddress = new Uri("https://launchlibrary.net/1.3/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<LaunchList> GetLaunchListAsync()
        {
            HttpResponseMessage response = await client.GetAsync("launch/next/5");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                //var launches = await response.Content.ReadAsAsync<LaunchList>();  // this would also work, but just to be sure

                var statusList = new StatusList();

                HttpResponseMessage statusResponse = await client.GetAsync("launchstatus");
                if (statusResponse.IsSuccessStatusCode)
                {
                    statusList = await statusResponse.Content.ReadAsAsync<StatusList>();
                }

                var launchList = JsonConvert.DeserializeObject<LaunchList>(stringResult);
                foreach (var launch in launchList.Launches)
                {
                    var status = statusList.Types.FirstOrDefault(t => t.Id == launch.Status);
                    if (status != null)
                    {
                        launch.StatusName = status.Name;
                        launch.StatusDesc = status.Description;
                    }
                }

                return launchList;
            }

            return new LaunchList();
        }

        public async Task<RocketList> GetRocketListAsync()
        {
            HttpResponseMessage response = await client.GetAsync("rocket");  // can also use the "limit" parameter to take only 5 but there's no way to check if the returned rockets has imageUrl
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RocketList>(stringResult);
                int rocketCount = 5;

                result.Count = rocketCount;
                result.Total = rocketCount;
                result.Rockets = result.Rockets
                    .Where(r => !string.IsNullOrEmpty(r.ImageUrl)).Take(rocketCount).ToList();

                // get the smallest imageUrl
                foreach (var rocket in result.Rockets)
                {
                    var smallSize = rocket.ImageSizes.Min();
                    var largeSize = rocket.ImageSizes.Max();

                    rocket.SmallImageUrl = rocket.ImageUrl
                        .Replace(string.Format($"_{largeSize}"), string.Format($"_{smallSize}"));
                }

                return result;
            }

            return new RocketList();
        }
    }
}
