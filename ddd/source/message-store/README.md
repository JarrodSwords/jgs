## Possible Implementations

### Dumb

* require components to poll for new events

### Smart

* push events to subscribed components

## Ideas

* it seems reasonable for the store itself to not be in charge of message persistence
* if the store is just a hub of messages, then message persistence can be handled by a repo
* this could streamline the store to crucial business logic like keeping track of message order
