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
                        AccesoId = c.Int(nullable: false, identity: true),
                        dFechaAcceso = c.DateTime(nullable: false, precision: 0),
                        bStatus = c.Boolean(nullable: false),
                        usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.AccesoId)
                .ForeignKey("dbo.Usuarios", t => t.usuario_UsuarioId)
                .Index(t => t.usuario_UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
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
                        membrecia_MembreciaId = c.Int(),
                        rol_RolId = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Membrecias", t => t.membrecia_MembreciaId)
                .ForeignKey("dbo.Roles", t => t.rol_RolId)
                .Index(t => t.membrecia_MembreciaId)
                .Index(t => t.rol_RolId);
            
            CreateTable(
                "dbo.Membrecias",
                c => new
                    {
                        MembreciaId = c.Int(nullable: false, identity: true),
                        sTipo = c.Int(nullable: false),
                        dPrecio = c.Double(nullable: false),
                        iPrerioricidad = c.Int(nullable: false),
                        dDescuento = c.Double(nullable: false),
                        dFechaRegistro = c.DateTime(nullable: false, precision: 0),
                        dFechaRenovacion = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.MembreciaId);
            
            CreateTable(
                "dbo.Pagos",
                c => new
                    {
                        PagoId = c.Int(nullable: false, identity: true),
                        dFechaPago = c.DateTime(nullable: false, precision: 0),
                        fkUsuarioEmpleado = c.Int(nullable: false),
                        dTotal = c.Double(nullable: false),
                        dDescuento = c.Double(nullable: false),
                        sComentario = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        membrecia_MembreciaId = c.Int(),
                    })
                .PrimaryKey(t => t.PagoId)
                .ForeignKey("dbo.Membrecias", t => t.membrecia_MembreciaId)
                .Index(t => t.membrecia_MembreciaId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        PermisoNegadoId = c.Int(nullable: false, identity: true),
                        permiso_PermisoId = c.Int(),
                        rol_RolId = c.Int(),
                    })
                .PrimaryKey(t => t.PermisoNegadoId)
                .ForeignKey("dbo.Permisos", t => t.permiso_PermisoId)
                .ForeignKey("dbo.Roles", t => t.rol_RolId)
                .Index(t => t.permiso_PermisoId)
                .Index(t => t.rol_RolId);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        PermisoId = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sDescripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PermisoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accesos", "usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "rol_RolId", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "rol_RolId", "dbo.Roles");
            DropForeignKey("dbo.PermisosNegados", "permiso_PermisoId", "dbo.Permisos");
            DropForeignKey("dbo.Usuarios", "membrecia_MembreciaId", "dbo.Membrecias");
            DropForeignKey("dbo.Pagos", "membrecia_MembreciaId", "dbo.Membrecias");
            DropIndex("dbo.PermisosNegados", new[] { "rol_RolId" });
            DropIndex("dbo.PermisosNegados", new[] { "permiso_PermisoId" });
            DropIndex("dbo.Pagos", new[] { "membrecia_MembreciaId" });
            DropIndex("dbo.Usuarios", new[] { "rol_RolId" });
            DropIndex("dbo.Usuarios", new[] { "membrecia_MembreciaId" });
            DropIndex("dbo.Accesos", new[] { "usuario_UsuarioId" });
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
