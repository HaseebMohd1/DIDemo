Reference : https://www.youtube.com/watch?v=RuLbLXDuJxA


__Consuming Services of Different Lifetimes__:

- ___Singleton Consuming Scoped/Transient:___
    - __Not Allowed:__ A singleton service cannot consume a scoped or transient service because the singleton's lifetime exceeds that of the scoped/transient service. This can lead to issues where the singleton holds onto references of disposed scoped/transient services, causing runtime errors.
Scoped Consuming Singleton/Transient:
    - __Allowed:__ A scoped service can consume a singleton or transient service. The singleton's lifetime is longer, so it remains valid throughout the scoped service's lifetime. Transient services are created anew each time, so they are safe to use within the scoped service.
Transient Consuming Singleton/Scoped:
    - __Allowed:__ A transient service can consume singleton or scoped services. Since transient services are short-lived, they can safely use services with longer or the same lifetimes.
