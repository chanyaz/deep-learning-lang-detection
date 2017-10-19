//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Threading;
using System.Collections.Generic;

namespace AssemblyCSharp
{
    public static class ChunkLoader
    {
        private static PCQueue queue = new PCQueue(1);


        public static void GenerateData(Chunk2 chunk)
        {
            // status 0 to 1
            queue.EngueueItem(() =>
            {
                PerlinWorldGenerator.CreateChunk(chunk);
                chunk.status = 1;
            });
        }

        /// <summary>
        /// Move from status 1 to 2 (data generated to light generated
        /// </summary>
        /// <param name="chunk">Chunk.</param>
        public static void GenerateLight(Chunk2 chunk)
        {
            queue.EngueueItem(() =>
            {
                chunk.SpreadDaylight();
                chunk.status = 2;
            });
        }

        public static void RenderChunk(Chunk2 chunk)
        {
            queue.EngueueItem(() =>
            {
                chunk.manager.renderer.RenderChunk(chunk);
                chunk.status = 3;
            });
        }

        /*public static void RequestChunk (ChunkManager manager, int x, int z) 
        {
            Chunk2 chunk = new Chunk2(manager, x, z);
            manager.SetChunk(x, z, chunk);

            queue.EngueueItem(() =>
            {
                PerlinWorldGenerator.CreateChunk(chunk);
                chunk.isDataLoaded = true;
                //chunk.SpreadDaylight();
                chunk.manager.renderer.RenderChunk(chunk);
            });

            StatsEngine.QueueLength = queue.QueueLength();
        }

        public static void RequestChunkRegeneration (ChunkManager manager, Chunk2 chunk)
        {
            if (chunk.xPosition == 8 && chunk.zPosition == 10)
            {
                int ii = 0;
            }
            
            queue.EngueueItem(() =>
            {

                if (chunk.xPosition == 8 && chunk.zPosition == 10)
                {
                    int ii = 0;
                }


                //PerlinWorldGenerator.CreateChunk(chunk);
                //chunk.isDataLoaded = true;
                //chunk.SpreadDaylight();
                try
                {
                    chunk.manager.renderer.RenderChunk(chunk);
                }
                catch(Exception ex)
                {
                    throw new Exception("error");
                }
                chunk.isQueuedForReRender = false;
            });
            
            StatsEngine.QueueLength = queue.QueueLength();
        }*/

        /*public static void RequestLightRegeneration (ChunkManager manager, Chunk2 chunk)
        {
            //need to stop dupes entering here
            if (chunk.xPosition == 8 && chunk.zPosition == 10)
            {
                int ii = 0;
            }

            queue.EngueueItem(() =>
            {
                if (chunk.xPosition == 8 && chunk.zPosition == 10)
                {
                    int ii = 0;
                }
                //PerlinWorldGenerator.CreateChunk(chunk);
                //chunk.isDataLoaded = true;
                //chunk.SpreadDaylight();
                chunk.manager.renderer.RenderChunk(chunk);
            });
            
            StatsEngine.QueueLength = queue.QueueLength();
        }*/


        public static void ShutDown()
        {
            queue.Shutdown(false);
        }
    }

    public class PCQueue
    {
        readonly object _locker = new object();
        Thread[] _workers;
        Queue<Action> _itemQ = new Queue<Action>();

        public PCQueue (int workerCount)
        {
            _workers = new Thread[workerCount];

            for (int i = 0; i < workerCount; i++)
            {
                (_workers[i]= new Thread(Consume)).Start();
            }
        }

        public int QueueLength()
        {
            return _itemQ.Count;
        }

        public void Shutdown (bool waitForWorkers)
        {
            foreach (Thread worker in _workers)
            {
                EngueueItem(null);
            }

            if (waitForWorkers)
            {
                foreach(Thread worker in _workers)
                {
                    worker.Join();
                }
            }
        }

        public void EngueueItem(Action item)
        {
            lock (_locker)
            {
                _itemQ.Enqueue(item);
                Monitor.Pulse(_locker);
            }
        }

        private void Consume()
        {
            while (true)
            {
                try
                {
                    Action item;
                    lock(_locker)
                    {
                        while(_itemQ.Count == 0) 
                        {
                            Monitor.Wait(_locker);
                        }
                        item = _itemQ.Dequeue();
                        StatsEngine.QueueLength = _itemQ.Count;
                    }
                    if (item == null) return;
                    item();
                }
                catch (Exception ex)
                {
                    int ii = 0;
                }
            }
        }
    }
}
