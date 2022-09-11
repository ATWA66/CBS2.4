Player instance = new Player();
instance.Play();
instance.Pause();
instance.Stop();
instance.Record();
interface IPlayable
{
    void Play() { }
    void Pause() { }
    void Stop() { }
}
interface IRecodable
{
    void Record() { }
    void Pause() { }
    void Stop() { }
}
class Player : IPlayable, IRecodable
{
   public void Play() {
        Console.WriteLine("play...");
    }
    public void Pause() {
        Console.WriteLine("pause record/playing");
    } 
    public void Stop() {
        Console.WriteLine("Stop playing/record");
    }
    public void Record() {
        Console.WriteLine("record...");
    }
}
