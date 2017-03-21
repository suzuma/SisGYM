namespace DescGym.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesos",
                c => new
                    {
                        pkAcceso = c.Int(nullable: false, identity: true),
                        dFechaAcceso = c.DateTime(nullable: false, precision: 0),
                        bStatus = c.Boolean(nullable: false),
                        usuario_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkAcceso)
                .ForeignKey("dbo.Usuarios", t => t.usuario_pkUsuario)
                .Index(t => t.usuario_pkUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sApellidos = c.String(nullable: false, unicode: false),
                        sDireccion = c.String(nullable: false, unicode: false),
                        sTelefono = c.String(nullable: false, unicode: false),
                        sEmail = c.String(nullable: false, unicode: false),
                        sColonia = c.String(nullable: false, unicode: false),
                        sCiudad = c.String(nullable: false, unicode: false),
                        sEstado = c.String(nullable: false, unicode: false),
                        sFotografia = c.String(nullable: false, unicode: false),
                        sIdentificacion = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        membrecia_pkMembrecia = c.Int(),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Membrecias", t => t.membrecia_pkMembrecia)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.membrecia_pkMembrecia)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Membrecias",
                c => new
                    {
                        pkMembrecia = c.Int(nullable: false, identity: true),
                        sTipo = c.Int(nullable: false),
                        dPrecio = c.Double(nullable: false),
                        iPrerioricidad = c.Int(nullable: false),
                        dDescuento = c.Double(nullable: false),
                        dFechaRegistro = c.DateTime(nullable: false, precision: 0),
                        dFechaRenovacion = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.pkMembrecia);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        pkPago = c.Int(nullable: false, identity: true),
                        dFechaPago = c.DateTime(nullable: false, precision: 0),
                        fkUsuarioEmpleado = c.Int(nullable: false),
                        dTotal = c.Double(nullable: false),
                        dDescuento = c.Double(nullable: false),
                        sComentario = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        membrecia_pkMembrecia = c.Int(),
                    })
                .PrimaryKey(t => t.pkPago)
                .ForeignKey("dbo.Membrecias", t => t.membrecia_pkMembrecia)
                .Index(t => t.membrecia_pkMembrecia);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRol = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.pkRol);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        pkPermisoNegado = c.Int(nullable: false, identity: true),
                        permiso_pkPermiso = c.Int(),
                        rol_pkRol = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegado)
                .ForeignKey("dbo.Permisos", t => t.permiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.rol_pkRol)
                .Index(t => t.permiso_pkPermiso)
                .Index(t => t.rol_pkRol);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sDescripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accesos", "usuario_pkUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "rol_pkRol", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "permiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Usuarios", "membrecia_pkMembrecia", "dbo.Membrecias");
            DropForeignKey("dbo.Pagos", "membrecia_pkMembrecia", "dbo.Membrecias");
            DropIndex("dbo.PermisosNegados", new[] { "rol_pkRol" });
            DropIndex("dbo.PermisosNegados", new[] { "permiso_pkPermiso" });
            DropIndex("dbo.Pagos", new[] { "membrecia_pkMembrecia" });
            DropIndex("dbo.Usuarios", new[] { "rol_pkRol" });
            DropIndex("dbo.Usuarios", new[] { "membrecia_pkMembrecia" });
            DropIndex("dbo.Accesos", new[] { "usuario_pkUsuario" });
            DropTable("dbo.Permisos");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Roles");
            DropTable("dbo.Pagos");
            DropTable("dbo.Membrecias");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Accesos");
        }
    }
}
