# Carga Diferida (Lazy Loading)

Este proyecto ejemplifica lo minimo necesario para lograr la carga diferida con entity framework.

Es un proyecto en .Net 8. En el lo mpas importante es definir la siguiente biblioteca:
```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="8.0.16" />
```
y definir el la configuracion del `Context`
```cs
.UseLazyLoadingProxies(true)
```

Es importante que las relaciones con otras entidades sean `virtual` y `public`.

Por ejemplo:
```cs
public virtual Brand Brand { get; set; }
```
El proxy reescribe el comportamiento de esos objetos