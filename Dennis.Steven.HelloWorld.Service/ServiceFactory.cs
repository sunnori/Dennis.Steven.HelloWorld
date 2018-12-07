using Dennis.Steven.HelloWorld.Service.Interfaces;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace Dennis.Steven.HelloWorld.Service
{
    public class ServiceFactory
    {
        public ServiceFactory()
        {
            Compose();
        }

        [Import(typeof(IMessageService))]
        public IMessageService MessageService { get; set; }

        private void Compose()
        {
            var directoryName = Path.GetDirectoryName(GetType().Assembly.Location);
            var directoryCatalog = new DirectoryCatalog(directoryName);
            var container = new CompositionContainer(directoryCatalog);

            container.ComposeParts(this);
        }
    }
}
