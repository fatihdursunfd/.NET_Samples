namespace Events
{
    public class PathControl
    {
        public delegate void PathHandler(long size);
        public event PathHandler PathControlEvent;

        public async Task Control(string path)
        {
            while (true)
            {
                await Task.Delay(1000);

                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                var files = directoryInfo.GetFiles();

                var size = await Task.Run(() =>
                    directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length)
                );

                var sizeMb = size / (1024 * 1024);

                if (sizeMb >= 5)
                {
                    PathControlEvent(sizeMb);
                    break;
                }

                await Console.Out.WriteLineAsync($"Current file size : {sizeMb} mb");

            }
        }

        public void Stop(long size)
        {
            Console.WriteLine($"File size has been exceed 5mb  ::: {size} ");
        }

    }
}