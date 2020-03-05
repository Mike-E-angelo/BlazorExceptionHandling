using System;

namespace Components {
	public interface IExceptions : IOperation<(Type Owner, Exception Exception)> {}
}