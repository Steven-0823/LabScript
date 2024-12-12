
using Microsoft.JSInterop;

namespace LabScript
{
	public class AlertService : IAsyncDisposable
	{
		readonly Lazy<Task<IJSObjectReference>> ijsObjectReference;

		public AlertService(IJSRuntime ijsRuntime)
		{
			this.ijsObjectReference = new Lazy<Task<IJSObjectReference>>();
		}

		public ValueTask DisposeAsync()
		{
			throw new NotImplementedException();
		}
	}
}
