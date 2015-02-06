namespace Labyrinth.Interfaces
{
    interface IRenderer
    {
        void EnqueueForRendering(GameObject obj);

        void RenderAll();

        void ClearQueue();
    }
}
