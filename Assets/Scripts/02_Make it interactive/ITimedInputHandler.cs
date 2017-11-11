// Using the underlying events control system of unity gives us many useful things, 
// like inspector routing of events
using UnityEngine.EventSystems;

// An interface is a "contract" that other scripts (classes) implement.
// This interface will be used to augment the GvrReticlePointer to allow timed clicks.
public interface ITimedInputHandler : IEventSystemHandler
{
	void HandleTimedInput();
}