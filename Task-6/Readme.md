| Concept                          | Description                                                                 |
|----------------------------------|-----------------------------------------------------------------------------|
| Delegate                         | `ThresholdReachedEventHandler` defines the signature for the event handler. |
| EventArgs                        | `ThresholdReachedEventArgs` carries data about the threshold event.        |
| Event                            | `ThresholdReached` event notifies when the counter reaches the threshold.  |
| Nullable Event                   | `ThresholdReached?` prevents null event invocation errors.                 |
| Event Invocation                 | `OnThresholdReached` raises the event when threshold is met.               |
| Encapsulation                    | `_threshold` and `_count` are private fields managed internally.           |
| Event Handler Class              | `Handlers` contains static methods to handle the event.                    |
| Console Interaction              | Reads user input (`i` to increment, `q` to quit).                          |
| Decoupling                       | Event publisher (`Counter`) and subscribers (`Handlers`) are independent.  |
| Custom EventArgs                | `ThresholdReachedEventArgs` extends `EventArgs` to pass custom data.       |
