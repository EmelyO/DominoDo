using Android.OS;

namespace DominoDO.Platforms.Android
{
    public class database
    {
        public void Export()
        {
            var origen = Path.Combine(FileSystem.AppDataDirectory, "dominodo.db");
            var destino = Path.Combine(
                global::Android.OS.Environment.GetExternalStoragePublicDirectory(
                    global::Android.OS.Environment.DirectoryDownloads).AbsolutePath,
                "dominodo.db");
            File.Copy(origen, destino, true);
        }
    }
}
