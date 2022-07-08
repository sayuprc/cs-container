using DIContainer.Exception;

namespace DIContainer
{
    public class Container
    {
        private Dictionary<Type, object> bindings = new Dictionary<Type, object>();

        /// <summary>
        /// 抽象とインスタンスを紐づける。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="concrete"></param>
        public void Bind<T>(object concrete)
        {
            this.bindings.Add(typeof(T), concrete);
        }

        /// <summary>
        /// 抽象と紐づいているインスタンスを取得する。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public T Get<T>()
        {
            var id = typeof(T);

            if (!this.Has(id))
            {
                throw new NotFoundException($"{id} is not found.");
            }

            var concrete = this.bindings[id];

            return (T)concrete;
        }

        /// <summary>
        /// 指定された抽象を持っているかどうか。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool Has(Type id)
        {
            return this.bindings.ContainsKey(id);
        }
    }
}