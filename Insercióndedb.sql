INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiuadId`, `CiudadId`) 
    VALUES (NULL, 'Juan José', 'Torres Perez', '1', '325-563254-5210', 'jose@gmail.com', 'Mi casa queda ahí', '505-6587-1254', NULL, '2');
INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`) 
    VALUES (NULL, 'Lo ultimo que se pierde es la esperanza', 'Le agradezco a los profes por enseñar bien y aguantar', 'ninguna observación', '1', '1');
INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`) 
    VALUES (NULL, '1', '3000', '100', '1', '3');

-- Persona 2
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'María Fernanda', 'López Hernández', 2, '234567890', 'maria@example.com', 'Calle 456, Ciudad Ejemplo', '555-234-5678', 2);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Tú puedes superar cualquier desafío que se presente.', 'Mis profesores han dejado una huella imborrable en mi vida y estoy agradecido por sus valiosas lecciones y orientación.', 'Mi pasión por las ciencias sociales se ha fortalecido a lo largo de mi educación, y espero continuar explorando este campo en el futuro.', 1, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 3, 1800.25, 2100.50, LAST_INSERT_ID(), 3);

-- Persona 3
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Javier', 'González Pérez', 1, '345678901', 'javier@example.com', 'Avenida 789, Ciudad Ejemplo', '555-345-6789', 3);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Cada esfuerzo te acerca más a tus metas.', 'Agradezco sinceramente a mis profesores por su dedicación y por desafiarme a superar mis propios límites.', 'Agradezco a mis profesores por fomentar un ambiente de aprendizaje colaborativo, lo que ha contribuido significativamente a mi crecimiento académico.', 2, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 2, 1600.75, 1900.25, LAST_INSERT_ID(), 2);

-- Persona 4
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Carolina', 'Ramírez Torres', 2, '456789012', 'carolina@example.com', 'Calle 123, Ciudad Ejemplo', '555-456-7890', 1);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'No importa cuán difícil parezca, estás en el camino correcto.', 'Cada día en el aula ha sido una oportunidad para aprender y crecer, y estoy agradecido por los docentes que han hecho esto posible.', 'Mi participación en actividades extracurriculares, como el club de debate, me ha ayudado a mejorar mis habilidades de comunicación y liderazgo.', 1, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1750.00, 1, 2050.50, LAST_INSERT_ID(), 1);

-- Persona 5
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Gabriel', 'Pérez Sánchez', 1, '567890123', 'gabriel@example.com', 'Avenida 789, Ciudad Ejemplo', '555-567-8901', 2);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Tu dedicación y trabajo arduo darán frutos increíbles.', 'Quiero extender mi gratitud a mis profesores por su pasión por enseñar y por ayudarme a crecer tanto personal como intelectualmente.', 'La oportunidad de realizar prácticas profesionales me ha permitido aplicar los conocimientos adquiridos en el aula a situaciones del mundo real.', 2, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1950.50, 3, 2200.00, LAST_INSERT_ID(), 3);

-- Persona 6
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Laura', 'Sánchez García', 2, '678901234', 'laura@example.com', 'Calle Principal, Ciudad Ejemplo', '555-678-9012', 2);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Confía en ti mismo y en tus habilidades, eres capaz de lograrlo.', 'Mis profesores han sido una influencia positiva en mi vida y estoy agradecido por su paciencia y sabiduría.', 'La diversidad cultural en mi institución educativa ha ampliado mi perspectiva y me ha brindado la oportunidad de aprender de diferentes culturas.', 1, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1850.25, 2, 2150.75, LAST_INSERT_ID(), 2);

-- Persona 7
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Manuel Alejandro', 'Torres Rodríguez', 1, '789012345', 'manuel@example.com', 'Avenida Central, Ciudad Ejemplo', '555-789-0123', 1);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Recuerda que cada obstáculo es una oportunidad para crecer.', 'No hay palabras suficientes para agradecer a mis docentes por su compromiso en mi aprendizaje y por ser una fuente constante de inspiración.', 'La mentoría de mis profesores ha sido esencial para mi desarrollo académico y personal, y estoy agradecido por su orientación constante.', 2, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1900.75, 1, 2000.25, LAST_INSERT_ID(), 1);

-- Persona 8
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Ana María', 'García López', 2, '890123456', 'ana@example.com', 'Calle Secundaria, Ciudad Ejemplo', '555-890-1234', 2);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Cada paso que das te acerca a tus sueños, sigue adelante.', 'Estoy profundamente agradecido por la guía invaluable que mis profesores me han brindado a lo largo de mi trayectoria académica.', 'He tenido el privilegio de asistir a conferencias inspiradoras que han ampliado mis horizontes y me han motivado a buscar el aprendizaje continuo.', 2, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 2050.25, 2, 2250.50, LAST_INSERT_ID(), 2);

-- Persona 9
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'David', 'López Sánchez', 1, '901234567', 'david@example.com', 'Avenida 123, Ciudad Ejemplo', '555-901-2345', 3);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Tu determinación es inspiradora, sigue persiguiendo tus sueños.', 'Quiero expresar mi sincero agradecimiento a todos mis profesores por su dedicación y apoyo constante en mi educación.', 'La experiencia de presentar proyectos frente a mis compañeros y profesores me ha ayudado a ganar confianza en mis habilidades de presentación.', 1, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1925.50, 3, 2050.00, LAST_INSERT_ID(), 3);

-- Persona 10 (última)
INSERT INTO `personas` (`Id`, `Nombres`, `Apellidos`, `Sexo`, `Cedula`, `Mail`, `Direccion`, `Telefono`, `CiudadId`)
VALUES (NULL, 'Elena', 'Martínez García', 2, '012345678', 'elena@example.com', 'Calle Principal, Ciudad Ejemplo', '555-012-3456', 1);

INSERT INTO `encuestaspersonales` (`Id`, `Palabrasalientos`, `Palabrasdeagradecimiento`, `Observacion`, `AreasdetrabajosId`, `PersonasId`)
VALUES (NULL, 'Nunca dejes de creer en ti misma y en tus capacidades.', 'Mis profesores han sido faros de conocimiento y guía en mi vida académica, y les estoy profundamente agradecida por su dedicación.', 'He tenido la oportunidad de liderar equipos en proyectos escolares, lo que ha fortalecido mis habilidades de liderazgo y trabajo en equipo.', 3, LAST_INSERT_ID());

INSERT INTO `encuestasgenericas` (`Id`, `T_area_trab`, `Cant_pago`, `Cant_pago_curso`, `PersonasId`, `AreasdeestudiosId`)
VALUES (NULL, 1800.00, 2, 2200.75, LAST_INSERT_ID(), 2);