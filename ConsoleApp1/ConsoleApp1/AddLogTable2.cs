using FluentMigrator;

namespace ConsoleApp1
{
    [Migration(20180430121802)]
    public class AddLogTable2 : Migration
    {
        public override void Up()
        {
            Execute.Sql(@"
 
                DROP PROCEDURE IF EXISTS `color_consultar`;

                CREATE DEFINER=`root`@`localhost` PROCEDURE `color_consultar`(
                IN opcion TINYINT(2),
                IN idProductoi INT,
                IN idColori INT)
                BEGIN
	                IF(opcion = 1)
	                THEN
		                SELECT 
		                  color.*, /* PRUEBA */
		                  prodcolor.cantidad 
		                FROM
		                  inventario_productocolor prodcolor,
		                  inventario_colores color 
		                WHERE prodcolor.color_id = color.id 
		                  AND producto_id = idProductoi AND (idColori IS NULL OR idColori = 0 OR color.id = idColori) ORDER BY color.nombre;	
	                END IF;
                END;

            ");
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
