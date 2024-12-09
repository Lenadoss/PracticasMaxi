SELECT D."Titulo", D."FechaLanzamiento", E."Descripcion" 
FROM "DISCOS" as D, "ESTILOS" as E
WHERE D."idEstilo" = E."Id"

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 
INSERT INTO "ESTILOS" ("Descripcion")
VALUES ('Reguetón')

SELECT ""
