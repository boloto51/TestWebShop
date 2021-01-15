using System.Threading.Tasks;
using TestWebShop.Converters;
using TestWebShop.Data.Repositories;
using TestWebShop.Models.Goods;

namespace TestWebShop.Managers
{
    public class GoodManager : IGoodManager
    {
        IGoodRepository _goodRepository;
        IGoodTypeRepository _goodTypeRepository;
        IProducerRepository _producerRepository;
        IGoodConverter _goodConverter;
        IGoodTypeConverter _godTypeConverter;
        IProducerConverter _producerConverter;

        public GoodManager(IGoodRepository goodRepository, IGoodTypeRepository goodTypeRepository,
            IProducerRepository producerRepository, IGoodConverter goodConverter,
        IGoodTypeConverter godTypeConverter, IProducerConverter producerConverter)
        {
            _goodRepository = goodRepository;
            _goodTypeRepository = goodTypeRepository;
            _producerRepository = producerRepository;
            _goodConverter = goodConverter;
            _godTypeConverter = godTypeConverter;
            _producerConverter = producerConverter;
        }

        public async Task AddRecordsToTable(Goods goods)
        {
            var goodEntity = _goodConverter.ToEntity(goods);
            var goodTypeEntity = _godTypeConverter.ToEntity(goods);
            var producerEntity = _producerConverter.ToEntity(goods);

            await _producerRepository.AddNotExists(producerEntity);
            await _goodTypeRepository.AddNotExists(goodTypeEntity);
            await _goodRepository.AddNotExists(goodEntity);
        }
    }
}
