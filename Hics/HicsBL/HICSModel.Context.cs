﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HicsBL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class itin18_aktEntities : DbContext
    {
        public itin18_aktEntities()
            : base("name=itin18_aktEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        [DbFunction("itin18_aktEntities", "fn_check_admin_table")]
        public virtual IQueryable<Nullable<int>> fn_check_admin_table(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<int>>("[itin18_aktEntities].[fn_check_admin_table](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_check_user_table")]
        public virtual IQueryable<Nullable<int>> fn_check_user_table(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<int>>("[itin18_aktEntities].[fn_check_user_table](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lamp_status")]
        public virtual IQueryable<fn_show_lamp_status_Result> fn_show_lamp_status(string username, string password, Nullable<int> lamp_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lamp_status_Result>("[itin18_aktEntities].[fn_show_lamp_status](@username, @password, @lamp_id)", usernameParameter, passwordParameter, lamp_idParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lampgroup")]
        public virtual IQueryable<fn_show_lampgroup_Result> fn_show_lampgroup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lampgroup_Result>("[itin18_aktEntities].[fn_show_lampgroup]()");
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lampgroup_status")]
        public virtual IQueryable<fn_show_lampgroup_status_Result> fn_show_lampgroup_status(string username, string password, Nullable<int> group_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var group_idParameter = group_id.HasValue ?
                new ObjectParameter("group_id", group_id) :
                new ObjectParameter("group_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lampgroup_status_Result>("[itin18_aktEntities].[fn_show_lampgroup_status](@username, @password, @group_id)", usernameParameter, passwordParameter, group_idParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lamps")]
        public virtual IQueryable<fn_show_lamps_Result> fn_show_lamps(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lamps_Result>("[itin18_aktEntities].[fn_show_lamps](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_usergroup")]
        public virtual IQueryable<fn_show_usergroup_Result> fn_show_usergroup(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_usergroup_Result>("[itin18_aktEntities].[fn_show_usergroup](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_users")]
        public virtual IQueryable<fn_show_users_Result> fn_show_users(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_users_Result>("[itin18_aktEntities].[fn_show_users](@username, @password)", usernameParameter, passwordParameter);
        }
    
        public virtual int sp_add_lamp(string username, string password, string address, string name)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_lamp", usernameParameter, passwordParameter, addressParameter, nameParameter);
        }
    
        public virtual int sp_add_lamp_to_lampgroup(string username, string password, Nullable<int> roomgroup_id, Nullable<int> lamp_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roomgroup_idParameter = roomgroup_id.HasValue ?
                new ObjectParameter("roomgroup_id", roomgroup_id) :
                new ObjectParameter("roomgroup_id", typeof(int));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_lamp_to_lampgroup", usernameParameter, passwordParameter, roomgroup_idParameter, lamp_idParameter);
        }
    
        public virtual int sp_add_lampgroup(string name, string password, string group_name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var group_nameParameter = group_name != null ?
                new ObjectParameter("group_name", group_name) :
                new ObjectParameter("group_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_lampgroup", nameParameter, passwordParameter, group_nameParameter);
        }
    
        public virtual int sp_add_user(string username, string password, string new_username, string new_password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var new_usernameParameter = new_username != null ?
                new ObjectParameter("new_username", new_username) :
                new ObjectParameter("new_username", typeof(string));
    
            var new_passwordParameter = new_password != null ?
                new ObjectParameter("new_password", new_password) :
                new ObjectParameter("new_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_user", usernameParameter, passwordParameter, new_usernameParameter, new_passwordParameter);
        }
    
        public virtual int sp_add_usergroup(string username, string password, string gourpname)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var gourpnameParameter = gourpname != null ?
                new ObjectParameter("gourpname", gourpname) :
                new ObjectParameter("gourpname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_add_usergroup", usernameParameter, passwordParameter, gourpnameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_change_password(string name, string oldpassword, string newpassword)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var oldpasswordParameter = oldpassword != null ?
                new ObjectParameter("oldpassword", oldpassword) :
                new ObjectParameter("oldpassword", typeof(string));
    
            var newpasswordParameter = newpassword != null ?
                new ObjectParameter("newpassword", newpassword) :
                new ObjectParameter("newpassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_change_password", nameParameter, oldpasswordParameter, newpasswordParameter);
        }
    
        public virtual int sp_change_password_by_admin(string username, string password, Nullable<int> change_id, string newpassword)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var change_idParameter = change_id.HasValue ?
                new ObjectParameter("change_id", change_id) :
                new ObjectParameter("change_id", typeof(int));
    
            var newpasswordParameter = newpassword != null ?
                new ObjectParameter("newpassword", newpassword) :
                new ObjectParameter("newpassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_change_password_by_admin", usernameParameter, passwordParameter, change_idParameter, newpasswordParameter);
        }
    
        public virtual int sp_delete_lamp(Nullable<int> lamp_id, string username, string password)
        {
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_lamp", lamp_idParameter, usernameParameter, passwordParameter);
        }
    
        public virtual int sp_delete_lamp_from_roomgroup(string username, string password, Nullable<int> roomgroup_id, Nullable<int> lamp_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roomgroup_idParameter = roomgroup_id.HasValue ?
                new ObjectParameter("roomgroup_id", roomgroup_id) :
                new ObjectParameter("roomgroup_id", typeof(int));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_lamp_from_roomgroup", usernameParameter, passwordParameter, roomgroup_idParameter, lamp_idParameter);
        }
    
        public virtual int sp_delete_roomgroup(string username, string password, Nullable<int> roomgroup_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roomgroup_idParameter = roomgroup_id.HasValue ?
                new ObjectParameter("roomgroup_id", roomgroup_id) :
                new ObjectParameter("roomgroup_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_roomgroup", usernameParameter, passwordParameter, roomgroup_idParameter);
        }
    
        public virtual int sp_delete_user(string username, string password, Nullable<int> del_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var del_idParameter = del_id.HasValue ?
                new ObjectParameter("del_id", del_id) :
                new ObjectParameter("del_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_user", usernameParameter, passwordParameter, del_idParameter);
        }
    
        public virtual int sp_delete_usergroup(string username, string password, Nullable<int> del_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var del_idParameter = del_id.HasValue ?
                new ObjectParameter("del_id", del_id) :
                new ObjectParameter("del_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_delete_usergroup", usernameParameter, passwordParameter, del_idParameter);
        }
    
        public virtual int sp_insert_test_data()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert_test_data");
        }
    
        public virtual int sp_lamp_dimm(string username, string password, Nullable<int> lamp_id, Nullable<byte> bright)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            var brightParameter = bright.HasValue ?
                new ObjectParameter("bright", bright) :
                new ObjectParameter("bright", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lamp_dimm", usernameParameter, passwordParameter, lamp_idParameter, brightParameter);
        }
    
        public virtual int sp_lamp_off(string username, string password, Nullable<int> lamp_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lamp_off", usernameParameter, passwordParameter, lamp_idParameter);
        }
    
        public virtual int sp_lamp_on(string username, string password, Nullable<int> lamp_id)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var lamp_idParameter = lamp_id.HasValue ?
                new ObjectParameter("lamp_id", lamp_id) :
                new ObjectParameter("lamp_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lamp_on", usernameParameter, passwordParameter, lamp_idParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lampgroups")]
        public virtual IQueryable<fn_show_lampgroups_Result> fn_show_lampgroups(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lampgroups_Result>("[itin18_aktEntities].[fn_show_lampgroups](@username, @password)", usernameParameter, passwordParameter);
        }
    
        [DbFunction("itin18_aktEntities", "fn_show_lamps1")]
        public virtual IQueryable<fn_show_lamps1_Result> fn_show_lamps1(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_show_lamps1_Result>("[itin18_aktEntities].[fn_show_lamps1](@username, @password)", usernameParameter, passwordParameter);
        }
    }
}
