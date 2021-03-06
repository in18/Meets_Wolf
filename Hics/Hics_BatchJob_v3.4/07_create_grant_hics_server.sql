USE [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_change_password] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lampgroup_status] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lamp_status] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_lamp_dimm] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_usergroup] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_lamp_on] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_check_user_table] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_users] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_user] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_lamp_off] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_lamp_from_roomgroup] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_lamp_to_lampgroup] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_insert_test_data] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_usergroup] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lampgroups] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_lampgroup] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_roomgroup] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_user] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_lamp] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_change_password_by_admin] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_usergroups] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_lamp] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_check_admin_table] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lamps] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_add_user_to_usergroup] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_deleted_lamps] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_deleted_roomgroups] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_deleted_users] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_deleted_usergroups] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lamp_control_history] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lamp_control] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_delete_user_from_usergroup] TO [itin18_akt]
GO

GRANT SELECT ON [dbo].[fn_show_lampgroup_allocate] TO [itin18_akt]
GO

GRANT EXECUTE ON [dbo].[sp_set_lamp_stat] TO [itin18_akt]
GO
