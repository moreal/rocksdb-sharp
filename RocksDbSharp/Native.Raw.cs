﻿using System;
using System.Runtime.InteropServices;
using byte_ptr = System.IntPtr;
using int_ptr = System.IntPtr;
using size_t = System.UIntPtr;
using const_size_t = System.UIntPtr;
using uint32_t = System.UInt32;
using unsigned_int = System.UInt32;
using int32_t = System.Int32;
using int64_t = System.Int64;
using uint64_t = System.UInt64;
using uint64_t_ptr = System.IntPtr;
using unsigned_char = System.Boolean;
using unsigned_char_ptr = System.IntPtr;
using char_ptr = System.IntPtr;
using const_char_ptr = System.IntPtr;
using char_ptr_ptr = System.IntPtr;
using const_char_ptr_const_ptr = System.IntPtr;
using const_char_ptr_ptr = System.IntPtr;
using const_size_t_ptr = System.IntPtr;
using void_ptr = System.IntPtr;
using size_t_ptr = System.IntPtr;

#pragma warning disable IDE1006 // Intentionally violating naming conventions because this is meant to match the C API
namespace RocksDbSharp
{
    #region Type aliases
    using rocksdb_t_ptr = System.IntPtr;
    using rocksdb_backup_engine_t_ptr = System.IntPtr;
    using const_rocksdb_backup_engine_info_t_ptr = System.IntPtr;
    using rocksdb_restore_options_t_ptr = System.IntPtr;
    using const_rocksdb_restore_options_t_ptr = System.IntPtr;
    using rocksdb_cache_t_ptr = System.IntPtr;
    using rocksdb_compactionfilter_t_ptr = System.IntPtr;
    using rocksdb_compactionfiltercontext_t_ptr = System.IntPtr;
    using rocksdb_compactionfilterfactory_t_ptr = System.IntPtr;
    using rocksdb_comparator_t_ptr = System.IntPtr;
    using const_rocksdb_comparator_t_ptr = System.IntPtr;
    using const_rocksdb_dbpath_t_ptr_ptr = System.IntPtr;
    using rocksdb_dbpath_t_ptr = System.IntPtr;
    using rocksdb_env_t_ptr = System.IntPtr;
    using rocksdb_fifo_compaction_options_t_ptr = System.IntPtr;
    using rocksdb_filterpolicy_t_ptr = System.IntPtr;
    using const_rocksdb_flushoptions_t_ptr = System.IntPtr;
    using rocksdb_flushoptions_t_ptr = System.IntPtr;
    using rocksdb_iterator_t_ptr = System.IntPtr;
    using rocksdb_iterator_t_ptr_ptr = System.IntPtr;
    using const_rocksdb_iterator_t_ptr = System.IntPtr;
    using rocksdb_logger_t_ptr = System.IntPtr;
    using rocksdb_mergeoperator_t_ptr = System.IntPtr;
    using const_rocksdb_options_t_ptr = System.IntPtr;
    using const_rocksdb_options_t_ptr_ptr = System.IntPtr;
    using rocksdb_options_t_ptr = System.IntPtr;
    using rocksdb_compactoptions_t_ptr = System.IntPtr;
    using rocksdb_block_based_table_options_t_ptr = System.IntPtr;
    using rocksdb_cuckoo_table_options_t_ptr = System.IntPtr;
    using const_rocksdb_readoptions_t_ptr = System.IntPtr;
    using rocksdb_readoptions_t_ptr = System.IntPtr;
    using rocksdb_slicetransform_t_ptr = System.IntPtr;
    using const_rocksdb_snapshot_t_ptr = System.IntPtr;
    using rocksdb_writebatch_t_ptr = System.IntPtr;
    using rocksdb_writebatch_wi_t_ptr = System.IntPtr;
    using const_rocksdb_writeoptions_t_ptr = System.IntPtr;
    using rocksdb_writeoptions_t_ptr = System.IntPtr;
    using rocksdb_universal_compaction_options_t_ptr = System.IntPtr;
    using const_rocksdb_livefiles_t_ptr = System.IntPtr;
    using rocksdb_column_family_handle_t_ptr_ptr = System.IntPtr;
    using rocksdb_column_family_handle_t_ptr = System.IntPtr;
    using const_rocksdb_column_family_handle_t_ptr_const_ptr = System.IntPtr;
    using rocksdb_envoptions_t_ptr = System.IntPtr;
    using const_rocksdb_envoptions_t_ptr = System.IntPtr;
    using rocksdb_ingestexternalfileoptions_t_ptr = System.IntPtr;
    using const_rocksdb_ingestexternalfileoptions_t_ptr = System.IntPtr;
    using rocksdb_sstfilewriter_t_ptr = System.IntPtr;
    using rocksdb_ratelimiter_t_ptr = System.IntPtr;
    using rocksdb_pinnableslice_t_ptr = System.IntPtr;
    using const_rocksdb_pinnableslice_t_ptr = System.IntPtr;
    using const_rocksdb_transactiondb_options_t_ptr = System.IntPtr;
    using rocksdb_transactiondb_options_t_ptr = System.IntPtr;
    using rocksdb_transactiondb_t_ptr = System.IntPtr;
    using const_rocksdb_transaction_options_t_ptr = System.IntPtr;
    using rocksdb_transaction_options_t_ptr = System.IntPtr;
    using rocksdb_optimistictransactiondb_t_ptr = System.IntPtr;
    using const_rocksdb_optimistictransaction_options_t_ptr = System.IntPtr;
    using rocksdb_optimistictransaction_options_t_ptr = System.IntPtr;
    using rocksdb_transaction_t_ptr = System.IntPtr;
    using rocksdb_checkpoint_t_ptr = System.IntPtr;
    #endregion
    #region Delegates
    public delegate void PutDelegate(void_ptr p0, const_char_ptr k, size_t klen, const_char_ptr v, size_t vlen);
    public delegate void DeletedDelegate(void_ptr p0, const_char_ptr k, size_t klen);
    public delegate void DestructorDelegate(void_ptr p0);
    public delegate char FilterDelegate(void_ptr p0, int level, const_char_ptr key, size_t key_length, const_char_ptr existing_value, size_t value_length, char_ptr_ptr new_value, size_t_ptr new_value_length, unsigned_char_ptr value_changed);
    public delegate char_ptr NameDelegate(void_ptr p0);
    public delegate rocksdb_compactionfilter_t_ptr CreateCompactionFilterDelegate(void_ptr p0, rocksdb_compactionfiltercontext_t_ptr context);
    public delegate int CompareDelegate(void_ptr p0, const_char_ptr a, size_t alen, const_char_ptr b, size_t blen);
    public delegate char_ptr CreateFilterDelegate(void_ptr p0, const_char_ptr_const_ptr key_array, const_size_t_ptr key_length_array, int num_keys, size_t_ptr filter_length);
    public delegate char KeyMayMatchDelegate(void_ptr p0, const_char_ptr key, size_t length, const_char_ptr filter, size_t filter_length);
    public delegate void DeleteFilterDelegate(void_ptr p0, const_char_ptr filter, size_t filter_length);
    public delegate char_ptr FullMergeDelegate(void_ptr p0, const_char_ptr key, size_t key_length, const_char_ptr existing_value, size_t existing_value_length, const_char_ptr_const_ptr operands_list, const_size_t_ptr operands_list_length, int num_operands, unsigned_char_ptr success, size_t_ptr new_value_length);
    public delegate char_ptr PartialMergeDelegate(void_ptr p0, const_char_ptr key, size_t key_length, const_char_ptr_const_ptr operands_list, const_size_t_ptr operands_list_length, int num_operands, unsigned_char_ptr success, size_t_ptr new_value_length);
    public delegate void DeleteValueDelegate(void_ptr p0, const_char_ptr value, size_t value_length);
    public delegate char_ptr TransformDelegate(void_ptr p0, const_char_ptr key, size_t length, size_t_ptr dst_length);
    public delegate char InDomainDelegate(void_ptr p0, const_char_ptr key, size_t length);
    public delegate char InRangeDelegate(void_ptr p0, const_char_ptr key, size_t length);
    #endregion
    #region DB operations
    public partial class Native
    {
        public abstract rocksdb_t_ptr rocksdb_open(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open(
            const_rocksdb_options_t_ptr options,
            string name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only(
            const_rocksdb_options_t_ptr options,
            string name,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract rocksdb_backup_engine_t_ptr rocksdb_backup_engine_open(
            const_rocksdb_options_t_ptr options,
            const_char_ptr path,
            out char_ptr_ptr errptr);

        public abstract rocksdb_backup_engine_t_ptr rocksdb_backup_engine_open(
            const_rocksdb_options_t_ptr options,
            string path,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_backup_engine_create_new_backup(
            rocksdb_backup_engine_t_ptr be,
            rocksdb_t_ptr db,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_backup_engine_purge_old_backups(
            rocksdb_backup_engine_t_ptr be,
            uint32_t num_backups_to_keep,
            out char_ptr_ptr errptr);

        public abstract rocksdb_restore_options_t_ptr rocksdb_restore_options_create();

        public abstract void rocksdb_restore_options_destroy(
            rocksdb_restore_options_t_ptr opt);

        public abstract void rocksdb_restore_options_set_keep_log_files(
            rocksdb_restore_options_t_ptr opt,
            int v);

        public abstract void rocksdb_backup_engine_restore_db_from_latest_backup(
            rocksdb_backup_engine_t_ptr be,
            const_char_ptr db_dir,
            const_char_ptr wal_dir,
            const_rocksdb_restore_options_t_ptr restore_options,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_backup_engine_restore_db_from_latest_backup(
            rocksdb_backup_engine_t_ptr be,
            string db_dir,
            string wal_dir,
            const_rocksdb_restore_options_t_ptr restore_options,
            out char_ptr_ptr errptr);

        public abstract const_rocksdb_backup_engine_info_t_ptr rocksdb_backup_engine_get_backup_info(
            rocksdb_backup_engine_t_ptr be);

        public abstract int rocksdb_backup_engine_info_count(
            const_rocksdb_backup_engine_info_t_ptr info);

        public abstract int64_t rocksdb_backup_engine_info_timestamp(
            const_rocksdb_backup_engine_info_t_ptr info,
            int index);

        public abstract uint32_t rocksdb_backup_engine_info_backup_id(
            const_rocksdb_backup_engine_info_t_ptr info,
            int index);

        public abstract uint64_t rocksdb_backup_engine_info_size(
            const_rocksdb_backup_engine_info_t_ptr info,
            int index);

        public abstract uint32_t rocksdb_backup_engine_info_number_files(
            const_rocksdb_backup_engine_info_t_ptr info,
            int index);

        public abstract void rocksdb_backup_engine_info_destroy(
            const_rocksdb_backup_engine_info_t_ptr info);

        public abstract void rocksdb_backup_engine_close(
            rocksdb_backup_engine_t_ptr be);

        public abstract rocksdb_checkpoint_t_ptr rocksdb_checkpoint_object_create(
            rocksdb_t_ptr db,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_checkpoint_create(
            rocksdb_checkpoint_t_ptr checkpoint,
            const_char_ptr checkpoint_dir,
            uint64_t log_size_for_flush,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_checkpoint_create(
            rocksdb_checkpoint_t_ptr checkpoint,
            string checkpoint_dir,
            uint64_t log_size_for_flush,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_checkpoint_object_destroy(
            rocksdb_checkpoint_t_ptr checkpoint);

        public abstract rocksdb_t_ptr rocksdb_open_column_families(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            int num_column_families,
            const_char_ptr_ptr column_family_names,
            const_rocksdb_options_t_ptr_ptr column_family_options,
            rocksdb_column_family_handle_t_ptr_ptr column_family_handles,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_column_families(
            const_rocksdb_options_t_ptr options,
            string name,
            int num_column_families,
            const_char_ptr_ptr column_family_names,
            const_rocksdb_options_t_ptr_ptr column_family_options,
            rocksdb_column_family_handle_t_ptr_ptr column_family_handles,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_column_families(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            int num_column_families,
            string[] column_family_names,
            const_rocksdb_options_t_ptr[] column_family_options,
            rocksdb_column_family_handle_t_ptr[] column_family_handles,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_column_families(
            const_rocksdb_options_t_ptr options,
            string name,
            int num_column_families,
            string[] column_family_names,
            const_rocksdb_options_t_ptr[] column_family_options,
            rocksdb_column_family_handle_t_ptr[] column_family_handles,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only_column_families(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            int num_column_families,
            const_char_ptr_ptr column_family_names,
            const_rocksdb_options_t_ptr_ptr column_family_options,
            rocksdb_column_family_handle_t_ptr_ptr column_family_handles,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only_column_families(
            const_rocksdb_options_t_ptr options,
            string name,
            int num_column_families,
            const_char_ptr_ptr column_family_names,
            const_rocksdb_options_t_ptr_ptr column_family_options,
            rocksdb_column_family_handle_t_ptr_ptr column_family_handles,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only_column_families(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            int num_column_families,
            string[] column_family_names,
            const_rocksdb_options_t_ptr[] column_family_options,
            rocksdb_column_family_handle_t_ptr[] column_family_handles,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract rocksdb_t_ptr rocksdb_open_for_read_only_column_families(
            const_rocksdb_options_t_ptr options,
            string name,
            int num_column_families,
            string[] column_family_names,
            const_rocksdb_options_t_ptr[] column_family_options,
            rocksdb_column_family_handle_t_ptr[] column_family_handles,
            unsigned_char error_if_log_file_exist,
            out char_ptr_ptr errptr);

        public abstract char_ptr_ptr rocksdb_list_column_families(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            out size_t lencf,
            out char_ptr_ptr errptr);

        public abstract char_ptr_ptr rocksdb_list_column_families(
            const_rocksdb_options_t_ptr options,
            string name,
            out size_t lencf,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_list_column_families_destroy(
            char_ptr_ptr list,
            size_t len);

        public abstract void rocksdb_list_column_families_destroy(
            IntPtr[] list,
            size_t len);

        public abstract rocksdb_column_family_handle_t_ptr rocksdb_create_column_family(
            rocksdb_t_ptr db,
            const_rocksdb_options_t_ptr column_family_options,
            const_char_ptr column_family_name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_column_family_handle_t_ptr rocksdb_create_column_family(
            rocksdb_t_ptr db,
            const_rocksdb_options_t_ptr column_family_options,
            string column_family_name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_drop_column_family(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr handle,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_column_family_handle_destroy(
            rocksdb_column_family_handle_t_ptr column_family_handle);

        public abstract void rocksdb_close(
            rocksdb_t_ptr db);

        public abstract void rocksdb_put(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_put(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_put(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_put_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_put_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_put_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_delete(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_delete_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_merge(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_merge(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_merge(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_merge_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_merge_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_merge_cf(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_write(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_writebatch_t_ptr batch,
            out char_ptr_ptr errptr);

        /* Returns NULL if not found.  A malloc()ed array otherwise.
           Stores the length of the array in *vallen. */
        public abstract char_ptr rocksdb_get(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        /* Returns NULL if not found.  A malloc()ed array otherwise.
           Stores the length of the array in *vallen. */
        public unsafe abstract char_ptr rocksdb_get(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        /* Returns NULL if not found.  A malloc()ed array otherwise.
           Stores the length of the array in *vallen. */
        public abstract char_ptr rocksdb_get(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_get_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_get_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_get_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        // if values_list[i] == NULL and errs[i] == NULL,
        // then we got status.IsNotFound(), which we will not return.
        // all errors except status status.ok() and status.IsNotFound() are returned.
        //
        // errs, values_list and values_list_sizes must be num_keys in length,
        // allocated by the caller.
        // errs is a list of strings as opposed to the conventional one error,
        // where errs[i] is the status for retrieval of keys_list[i].
        // each non-NULL errs entry is a malloc()ed, null terminated string.
        // each non-NULL values_list entry is a malloc()ed array, with
        // the length for each stored in values_list_sizes[i].
        public abstract void rocksdb_multi_get(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            size_t num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            char_ptr_ptr values_list,
            size_t_ptr values_list_sizes,
            char_ptr[] errs);

        // if values_list[i] == NULL and errs[i] == NULL,
        // then we got status.IsNotFound(), which we will not return.
        // all errors except status status.ok() and status.IsNotFound() are returned.
        //
        // errs, values_list and values_list_sizes must be num_keys in length,
        // allocated by the caller.
        // errs is a list of strings as opposed to the conventional one error,
        // where errs[i] is the status for retrieval of keys_list[i].
        // each non-NULL errs entry is a malloc()ed, null terminated string.
        // each non-NULL values_list entry is a malloc()ed array, with
        // the length for each stored in values_list_sizes[i].
        public abstract void rocksdb_multi_get(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            size_t num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            IntPtr[] values_list,
            size_t[] values_list_sizes,
            char_ptr[] errs);

        public abstract void rocksdb_multi_get_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            const_rocksdb_column_family_handle_t_ptr_const_ptr column_families,
            size_t num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            char_ptr_ptr values_list,
            size_t_ptr values_list_sizes,
            char_ptr[] errs);

        public abstract void rocksdb_multi_get_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr[] column_families,
            size_t num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            IntPtr[] values_list,
            size_t[] values_list_sizes,
            char_ptr[] errs);

        public abstract rocksdb_iterator_t_ptr rocksdb_create_iterator(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options);

        public abstract rocksdb_iterator_t_ptr rocksdb_create_iterator_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family);

        public abstract void rocksdb_create_iterators(
            rocksdb_t_ptr db,
            rocksdb_readoptions_t_ptr opts,
            rocksdb_column_family_handle_t_ptr_ptr column_families,
            rocksdb_iterator_t_ptr_ptr iterators,
            size_t size,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_create_iterators(
            rocksdb_t_ptr db,
            rocksdb_readoptions_t_ptr opts,
            rocksdb_column_family_handle_t_ptr[] column_families,
            rocksdb_iterator_t_ptr[] iterators,
            size_t size,
            out char_ptr_ptr errptr);

        public abstract const_rocksdb_snapshot_t_ptr rocksdb_create_snapshot(
            rocksdb_t_ptr db);

        public abstract void rocksdb_release_snapshot(
            rocksdb_t_ptr db,
            const_rocksdb_snapshot_t_ptr snapshot);

        /* Returns NULL if property name is unknown.
           Else returns a pointer to a malloc()-ed null-terminated value. */
        public abstract char_ptr rocksdb_property_value(
            rocksdb_t_ptr db,
            const_char_ptr propname);

        /* Returns NULL if property name is unknown.
           Else returns a pointer to a malloc()-ed null-terminated value. */
        public abstract char_ptr rocksdb_property_value(
            rocksdb_t_ptr db,
            string propname);

        public abstract char_ptr rocksdb_property_value_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr propname);

        public abstract char_ptr rocksdb_property_value_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            string propname);

        public abstract void rocksdb_approximate_sizes(
            rocksdb_t_ptr db,
            int num_ranges,
            const_char_ptr_const_ptr range_start_key,
            const_size_t_ptr range_start_key_len,
            const_char_ptr_const_ptr range_limit_key,
            const_size_t_ptr range_limit_key_len,
            uint64_t_ptr sizes);

        public abstract void rocksdb_approximate_sizes_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_ranges,
            const_char_ptr_const_ptr range_start_key,
            const_size_t_ptr range_start_key_len,
            const_char_ptr_const_ptr range_limit_key,
            const_size_t_ptr range_limit_key_len,
            uint64_t_ptr sizes);

        public abstract void rocksdb_compact_range(
            rocksdb_t_ptr db,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len);

        public unsafe abstract void rocksdb_compact_range(
            rocksdb_t_ptr db,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range(
            rocksdb_t_ptr db,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len);

        public unsafe abstract void rocksdb_compact_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_opt(
            rocksdb_t_ptr db,
            rocksdb_compactoptions_t_ptr opt,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len);

        public unsafe abstract void rocksdb_compact_range_opt(
            rocksdb_t_ptr db,
            rocksdb_compactoptions_t_ptr opt,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_opt(
            rocksdb_t_ptr db,
            rocksdb_compactoptions_t_ptr opt,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_cf_opt(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            rocksdb_compactoptions_t_ptr opt,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len);

        public unsafe abstract void rocksdb_compact_range_cf_opt(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            rocksdb_compactoptions_t_ptr opt,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_compact_range_cf_opt(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            rocksdb_compactoptions_t_ptr opt,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len);

        public abstract void rocksdb_delete_file(
            rocksdb_t_ptr db,
            const_char_ptr name);

        public abstract void rocksdb_delete_file(
            rocksdb_t_ptr db,
            string name);

        public abstract const_rocksdb_livefiles_t_ptr rocksdb_livefiles(
            rocksdb_t_ptr db);

        public abstract void rocksdb_flush(
            rocksdb_t_ptr db,
            const_rocksdb_flushoptions_t_ptr options,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_disable_file_deletions(
            rocksdb_t_ptr db,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_enable_file_deletions(
            rocksdb_t_ptr db,
            unsigned_char force,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // DB operations
    #region Management operations
    public partial class Native
    {
        public abstract void rocksdb_destroy_db(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_destroy_db(
            const_rocksdb_options_t_ptr options,
            string name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_repair_db(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_repair_db(
            const_rocksdb_options_t_ptr options,
            string name,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // Management operations
    #region Iterator
    public partial class Native
    {
        public abstract void rocksdb_iter_destroy(
            rocksdb_iterator_t_ptr iterator);

        public abstract unsigned_char rocksdb_iter_valid(
            const_rocksdb_iterator_t_ptr iterator);

        public abstract void rocksdb_iter_seek_to_first(
            rocksdb_iterator_t_ptr iterator);

        public abstract void rocksdb_iter_seek_to_last(
            rocksdb_iterator_t_ptr iterator);

        public abstract void rocksdb_iter_seek(
            rocksdb_iterator_t_ptr iterator,
            const_char_ptr k,
            size_t klen);

        public unsafe abstract void rocksdb_iter_seek(
            rocksdb_iterator_t_ptr iterator,
            byte* k,
            size_t klen);

        public abstract void rocksdb_iter_seek(
            rocksdb_iterator_t_ptr iterator,
            byte[] k,
            size_t klen);

        public abstract void rocksdb_iter_seek_for_prev(
            rocksdb_iterator_t_ptr iterator,
            const_char_ptr k,
            size_t klen);

        public unsafe abstract void rocksdb_iter_seek_for_prev(
            rocksdb_iterator_t_ptr iterator,
            byte* k,
            size_t klen);

        public abstract void rocksdb_iter_seek_for_prev(
            rocksdb_iterator_t_ptr iterator,
            byte[] k,
            size_t klen);

        public abstract void rocksdb_iter_next(
            rocksdb_iterator_t_ptr iterator);

        public abstract void rocksdb_iter_prev(
            rocksdb_iterator_t_ptr iterator);

        public abstract const_char_ptr rocksdb_iter_key(
            const_rocksdb_iterator_t_ptr iterator,
            out size_t klen);

        public abstract const_char_ptr rocksdb_iter_value(
            const_rocksdb_iterator_t_ptr iterator,
            out size_t vlen);

        public abstract void rocksdb_iter_get_error(
            const_rocksdb_iterator_t_ptr iterator,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // Iterator
    #region Write batch
    public partial class Native
    {
        public abstract rocksdb_writebatch_t_ptr rocksdb_writebatch_create();

        public abstract rocksdb_writebatch_t_ptr rocksdb_writebatch_create_from(
            const_char_ptr rep,
            size_t size);

        public unsafe abstract rocksdb_writebatch_t_ptr rocksdb_writebatch_create_from(
            byte* rep,
            size_t size);

        public abstract rocksdb_writebatch_t_ptr rocksdb_writebatch_create_from(
            byte[] rep,
            size_t size);

        public abstract void rocksdb_writebatch_destroy(
            rocksdb_writebatch_t_ptr writebatch);

        public abstract void rocksdb_writebatch_clear(
            rocksdb_writebatch_t_ptr writebatch);

        public abstract int rocksdb_writebatch_count(
            rocksdb_writebatch_t_ptr writebatch);

        public abstract void rocksdb_writebatch_put(
            rocksdb_writebatch_t_ptr writebatch,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_put(
            rocksdb_writebatch_t_ptr writebatch,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_put(
            rocksdb_writebatch_t_ptr writebatch,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_put_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_put_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_put_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_putv(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_putv(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_putv_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_putv_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_merge(
            rocksdb_writebatch_t_ptr writebatch,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_merge(
            rocksdb_writebatch_t_ptr writebatch,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_merge(
            rocksdb_writebatch_t_ptr writebatch,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_merge_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_merge_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_merge_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_mergev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_mergev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_mergev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_mergev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_delete(
            rocksdb_writebatch_t_ptr writebatch,
            const_char_ptr key,
            size_t klen);

        public unsafe abstract void rocksdb_writebatch_delete(
            rocksdb_writebatch_t_ptr writebatch,
            byte* key,
            size_t klen);

        public abstract void rocksdb_writebatch_delete(
            rocksdb_writebatch_t_ptr writebatch,
            byte[] key,
            size_t klen);

        public abstract void rocksdb_writebatch_delete_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen);

        public unsafe abstract void rocksdb_writebatch_delete_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen);

        public abstract void rocksdb_writebatch_delete_cf(
            rocksdb_writebatch_t_ptr writebatch,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen);

        public abstract void rocksdb_writebatch_deletev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes);

        public abstract void rocksdb_writebatch_deletev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes);

        public abstract void rocksdb_writebatch_deletev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes);

        public abstract void rocksdb_writebatch_deletev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes);

        public abstract void rocksdb_writebatch_delete_range(
            rocksdb_writebatch_t_ptr b,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr end_key,
            size_t end_key_len);

        public unsafe abstract void rocksdb_writebatch_delete_range(
            rocksdb_writebatch_t_ptr b,
            byte* start_key,
            size_t start_key_len,
            byte* end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_delete_range(
            rocksdb_writebatch_t_ptr b,
            byte[] start_key,
            size_t start_key_len,
            byte[] end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_delete_range_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr end_key,
            size_t end_key_len);

        public unsafe abstract void rocksdb_writebatch_delete_range_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* start_key,
            size_t start_key_len,
            byte* end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_delete_range_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] start_key,
            size_t start_key_len,
            byte[] end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_delete_rangev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr start_keys_list,
            const_size_t_ptr start_keys_list_sizes,
            const_char_ptr_const_ptr end_keys_list,
            const_size_t_ptr end_keys_list_sizes);

        public abstract void rocksdb_writebatch_delete_rangev(
            rocksdb_writebatch_t_ptr b,
            int num_keys,
            IntPtr[] start_keys_list,
            size_t[] start_keys_list_sizes,
            IntPtr[] end_keys_list,
            size_t[] end_keys_list_sizes);

        public abstract void rocksdb_writebatch_delete_rangev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr start_keys_list,
            const_size_t_ptr start_keys_list_sizes,
            const_char_ptr_const_ptr end_keys_list,
            const_size_t_ptr end_keys_list_sizes);

        public abstract void rocksdb_writebatch_delete_rangev_cf(
            rocksdb_writebatch_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] start_keys_list,
            size_t[] start_keys_list_sizes,
            IntPtr[] end_keys_list,
            size_t[] end_keys_list_sizes);

        public abstract void rocksdb_writebatch_put_log_data(
            rocksdb_writebatch_t_ptr writebatch,
            const_char_ptr blob,
            size_t len);

        public unsafe abstract void rocksdb_writebatch_put_log_data(
            rocksdb_writebatch_t_ptr writebatch,
            byte* blob,
            size_t len);

        public abstract void rocksdb_writebatch_put_log_data(
            rocksdb_writebatch_t_ptr writebatch,
            byte[] blob,
            size_t len);

        public abstract void rocksdb_writebatch_iterate(
            rocksdb_writebatch_t_ptr writebatch,
            void_ptr state,
            PutDelegate put,
            DeletedDelegate deleted);

        public abstract const_char_ptr rocksdb_writebatch_data(
            rocksdb_writebatch_t_ptr writebatch,
            out size_t size);

        public abstract void rocksdb_writebatch_set_save_point(
            rocksdb_writebatch_t_ptr writebatch);

        public abstract void rocksdb_writebatch_rollback_to_save_point(
            rocksdb_writebatch_t_ptr writebatch,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_writebatch_pop_save_point(
            rocksdb_writebatch_t_ptr writebatch,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // Write batch
    #region Write batch with index
    public partial class Native
    {
        public abstract rocksdb_writebatch_wi_t_ptr rocksdb_writebatch_wi_create(
            size_t reserved_bytes,
            unsigned_char overwrite_keys);

        public abstract rocksdb_writebatch_wi_t_ptr rocksdb_writebatch_wi_create_from(
            const_char_ptr rep,
            size_t size);

        public unsafe abstract rocksdb_writebatch_wi_t_ptr rocksdb_writebatch_wi_create_from(
            byte* rep,
            size_t size);

        public abstract rocksdb_writebatch_wi_t_ptr rocksdb_writebatch_wi_create_from(
            byte[] rep,
            size_t size);

        public abstract void rocksdb_writebatch_wi_destroy(
            rocksdb_writebatch_wi_t_ptr writebatch_wi);

        public abstract void rocksdb_writebatch_wi_clear(
            rocksdb_writebatch_wi_t_ptr writebatch_wi);

        public abstract int rocksdb_writebatch_wi_count(
            rocksdb_writebatch_wi_t_ptr b);

        public abstract void rocksdb_writebatch_wi_put(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_wi_put(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_put(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_put_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_wi_put_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_put_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_putv(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_wi_putv(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_wi_putv_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_wi_putv_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_wi_merge(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_wi_merge(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_merge(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_merge_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen);

        public unsafe abstract void rocksdb_writebatch_wi_merge_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_merge_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen);

        public abstract void rocksdb_writebatch_wi_mergev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_wi_mergev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_wi_mergev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes,
            int num_values,
            const_char_ptr_const_ptr values_list,
            const_size_t_ptr values_list_sizes);

        public abstract void rocksdb_writebatch_wi_mergev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes,
            int num_values,
            IntPtr[] values_list,
            size_t[] values_list_sizes);

        public abstract void rocksdb_writebatch_wi_delete(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            const_char_ptr key,
            size_t klen);

        public unsafe abstract void rocksdb_writebatch_wi_delete(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte* key,
            size_t klen);

        public abstract void rocksdb_writebatch_wi_delete(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte[] key,
            size_t klen);

        public abstract void rocksdb_writebatch_wi_delete_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen);

        public unsafe abstract void rocksdb_writebatch_wi_delete_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen);

        public abstract void rocksdb_writebatch_wi_delete_cf(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen);

        public abstract void rocksdb_writebatch_wi_deletev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_deletev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_deletev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr keys_list,
            const_size_t_ptr keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_deletev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] keys_list,
            size_t[] keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_delete_range(
            rocksdb_writebatch_wi_t_ptr b,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr end_key,
            size_t end_key_len);

        public unsafe abstract void rocksdb_writebatch_wi_delete_range(
            rocksdb_writebatch_wi_t_ptr b,
            byte* start_key,
            size_t start_key_len,
            byte* end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_wi_delete_range(
            rocksdb_writebatch_wi_t_ptr b,
            byte[] start_key,
            size_t start_key_len,
            byte[] end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_wi_delete_range_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr end_key,
            size_t end_key_len);

        public unsafe abstract void rocksdb_writebatch_wi_delete_range_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* start_key,
            size_t start_key_len,
            byte* end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_wi_delete_range_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] start_key,
            size_t start_key_len,
            byte[] end_key,
            size_t end_key_len);

        public abstract void rocksdb_writebatch_wi_delete_rangev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            const_char_ptr_const_ptr start_keys_list,
            const_size_t_ptr start_keys_list_sizes,
            const_char_ptr_const_ptr end_keys_list,
            const_size_t_ptr end_keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_delete_rangev(
            rocksdb_writebatch_wi_t_ptr b,
            int num_keys,
            IntPtr[] start_keys_list,
            size_t[] start_keys_list_sizes,
            IntPtr[] end_keys_list,
            size_t[] end_keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_delete_rangev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            const_char_ptr_const_ptr start_keys_list,
            const_size_t_ptr start_keys_list_sizes,
            const_char_ptr_const_ptr end_keys_list,
            const_size_t_ptr end_keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_delete_rangev_cf(
            rocksdb_writebatch_wi_t_ptr b,
            rocksdb_column_family_handle_t_ptr column_family,
            int num_keys,
            IntPtr[] start_keys_list,
            size_t[] start_keys_list_sizes,
            IntPtr[] end_keys_list,
            size_t[] end_keys_list_sizes);

        public abstract void rocksdb_writebatch_wi_put_log_data(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            const_char_ptr blob,
            size_t len);

        public unsafe abstract void rocksdb_writebatch_wi_put_log_data(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte* blob,
            size_t len);

        public abstract void rocksdb_writebatch_wi_put_log_data(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            byte[] blob,
            size_t len);

        public abstract void rocksdb_writebatch_wi_iterate(
            rocksdb_writebatch_wi_t_ptr b,
            void_ptr state,
            PutDelegate put,
            DeletedDelegate deleted);

        public abstract const_char_ptr rocksdb_writebatch_wi_data(
            rocksdb_writebatch_wi_t_ptr b,
            out size_t size);

        public abstract void rocksdb_writebatch_wi_set_save_point(
            rocksdb_writebatch_wi_t_ptr writebatch_wi);

        public abstract void rocksdb_writebatch_wi_rollback_to_save_point(
            rocksdb_writebatch_wi_t_ptr writebatch_wi,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_writebatch_wi_get_from_batch(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_writebatch_wi_get_from_batch_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            const_rocksdb_options_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_writebatch_wi_get_from_batch_and_db_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_write_writebatch_wi(
            rocksdb_t_ptr db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_writebatch_wi_t_ptr wbwi,
            out char_ptr_ptr errptr);

        public abstract rocksdb_iterator_t_ptr rocksdb_writebatch_wi_create_iterator_with_base(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_iterator_t_ptr base_iterator);

        public abstract rocksdb_iterator_t_ptr rocksdb_writebatch_wi_create_iterator_with_base_cf(
            rocksdb_writebatch_wi_t_ptr wbwi,
            rocksdb_iterator_t_ptr base_iterator,
            rocksdb_column_family_handle_t_ptr cf);

    } // class Native
    #endregion // Write batch with index
    #region Block based table options

    public enum BlockBasedTableIndexType
    {
        Binary = 0,
        Hash = 1,
        TwoLevelIndex = 2,
    }

    public partial class Native
    {
        public abstract rocksdb_block_based_table_options_t_ptr rocksdb_block_based_options_create();

        public abstract void rocksdb_block_based_options_destroy(
            rocksdb_block_based_table_options_t_ptr options);

        public abstract void rocksdb_block_based_options_set_block_size(
            rocksdb_block_based_table_options_t_ptr options,
            size_t block_size);

        public abstract void rocksdb_block_based_options_set_block_size_deviation(
            rocksdb_block_based_table_options_t_ptr options,
            int block_size_deviation);

        public abstract void rocksdb_block_based_options_set_block_restart_interval(
            rocksdb_block_based_table_options_t_ptr options,
            int block_restart_interval);

        public abstract void rocksdb_block_based_options_set_filter_policy(
            rocksdb_block_based_table_options_t_ptr options,
            rocksdb_filterpolicy_t_ptr filter_policy);

        public abstract void rocksdb_block_based_options_set_no_block_cache(
            rocksdb_block_based_table_options_t_ptr options,
            unsigned_char no_block_cache);

        public abstract void rocksdb_block_based_options_set_block_cache(
            rocksdb_block_based_table_options_t_ptr options,
            rocksdb_cache_t_ptr block_cache);

        public abstract void rocksdb_block_based_options_set_block_cache_compressed(
            rocksdb_block_based_table_options_t_ptr options,
            rocksdb_cache_t_ptr block_cache_compressed);

        public abstract void rocksdb_block_based_options_set_whole_key_filtering(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            unsigned_char whole_key_filtering);

        public abstract void rocksdb_block_based_options_set_format_version(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            int format_version);

        public abstract void rocksdb_block_based_options_set_index_type(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            BlockBasedTableIndexType index_type);

        // uses one of the above enums
        public abstract void rocksdb_block_based_options_set_hash_index_allow_collision(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            unsigned_char hash_index_allow_collision);

        public abstract void rocksdb_block_based_options_set_cache_index_and_filter_blocks(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            unsigned_char cache_index_and_filter_blocks);

        public abstract void rocksdb_block_based_options_set_pin_l0_filter_and_index_blocks_in_cache(
            rocksdb_block_based_table_options_t_ptr block_based_table_options,
            unsigned_char pin_l0_filter_and_index_blocks_in_cache);

        public abstract void rocksdb_options_set_block_based_table_factory(
            rocksdb_options_t_ptr opt,
            rocksdb_block_based_table_options_t_ptr table_options);

    } // class Native
    #endregion // Block based table options
    #region Cuckoo table options
    public partial class Native
    {
        public abstract rocksdb_cuckoo_table_options_t_ptr rocksdb_cuckoo_options_create();

        public abstract void rocksdb_cuckoo_options_destroy(
            rocksdb_cuckoo_table_options_t_ptr options);

        public abstract void rocksdb_cuckoo_options_set_hash_ratio(
            rocksdb_cuckoo_table_options_t_ptr options,
            double v);

        public abstract void rocksdb_cuckoo_options_set_max_search_depth(
            rocksdb_cuckoo_table_options_t_ptr options,
            uint32_t v);

        public abstract void rocksdb_cuckoo_options_set_cuckoo_block_size(
            rocksdb_cuckoo_table_options_t_ptr options,
            uint32_t v);

        public abstract void rocksdb_cuckoo_options_set_identity_as_first_hash(
            rocksdb_cuckoo_table_options_t_ptr options,
            unsigned_char v);

        public abstract void rocksdb_cuckoo_options_set_use_module_hash(
            rocksdb_cuckoo_table_options_t_ptr options,
            unsigned_char v);

        public abstract void rocksdb_options_set_cuckoo_table_factory(
            rocksdb_options_t_ptr opt,
            rocksdb_cuckoo_table_options_t_ptr table_options);

    } // class Native
    #endregion // Cuckoo table options
    #region Options

    public enum Recovery
    {
        TolerateCorruptedTailRecords = 0,
        AbsoluteConsistency = 1,
        PointInTime = 2,
        SkipAnyCorruptedRecords = 3,
    }


    public enum Compression
    {
        No = 0,
        Snappy = 1,
        Zlib = 2,
        Bz2 = 3,
        Lz4 = 4,
        Lz4hc = 5,
        Xpress = 6,
        Zstd = 7,
    }


    public enum Compaction
    {
        Level = 0,
        Universal = 1,
        Fifo = 2,
    }

    public partial class Native
    {
        public abstract void rocksdb_set_options(
            rocksdb_t_ptr db,
            int count,
            string[] keys,
            string[] values,
            out char_ptr_ptr errptr);

        public abstract rocksdb_options_t_ptr rocksdb_options_create();

        public abstract void rocksdb_options_destroy(
            rocksdb_options_t_ptr options);

        public abstract void rocksdb_options_increase_parallelism(
            rocksdb_options_t_ptr opt,
            int total_threads);

        public abstract void rocksdb_options_optimize_for_point_lookup(
            rocksdb_options_t_ptr opt,
            uint64_t block_cache_size_mb);

        public abstract void rocksdb_options_optimize_level_style_compaction(
            rocksdb_options_t_ptr opt,
            uint64_t memtable_memory_budget);

        public abstract void rocksdb_options_optimize_universal_style_compaction(
            rocksdb_options_t_ptr opt,
            uint64_t memtable_memory_budget);

        public abstract void rocksdb_options_set_compaction_filter(
            rocksdb_options_t_ptr options,
            rocksdb_compactionfilter_t_ptr compaction_filter);

        public abstract void rocksdb_options_set_compaction_filter_factory(
            rocksdb_options_t_ptr options,
            rocksdb_compactionfilterfactory_t_ptr compaction_filter_factory);

        public abstract void rocksdb_options_compaction_readahead_size(
            rocksdb_options_t_ptr options,
            size_t size);

        public abstract void rocksdb_options_set_comparator(
            rocksdb_options_t_ptr options,
            rocksdb_comparator_t_ptr comparator);

        public abstract void rocksdb_options_set_merge_operator(
            rocksdb_options_t_ptr options,
            rocksdb_mergeoperator_t_ptr merge_operator);

        public abstract void rocksdb_options_set_uint64add_merge_operator(
            rocksdb_options_t_ptr options);

        public abstract void rocksdb_options_set_compression_per_level(
            rocksdb_options_t_ptr opt,
            Compression[] level_values,
            size_t num_levels);

        public abstract void rocksdb_options_set_create_if_missing(
            rocksdb_options_t_ptr options,
            unsigned_char create_if_missing);

        public abstract void rocksdb_options_set_create_missing_column_families(
            rocksdb_options_t_ptr options,
            unsigned_char create_missing_column_families);

        public abstract void rocksdb_options_set_error_if_exists(
            rocksdb_options_t_ptr options,
            unsigned_char error_if_exists);

        public abstract void rocksdb_options_set_paranoid_checks(
            rocksdb_options_t_ptr options,
            unsigned_char paranoid_checks);

        public abstract void rocksdb_options_set_db_paths(
            rocksdb_options_t_ptr options,
            const_rocksdb_dbpath_t_ptr_ptr path_values,
            size_t num_paths);

        public abstract void rocksdb_options_set_env(
            rocksdb_options_t_ptr options,
            rocksdb_env_t_ptr env);

        public abstract void rocksdb_options_set_info_log(
            rocksdb_options_t_ptr options,
            rocksdb_logger_t_ptr info_log);

        public abstract void rocksdb_options_set_info_log_level(
            rocksdb_options_t_ptr options,
            int info_log_level);

        public abstract void rocksdb_options_set_write_buffer_size(
            rocksdb_options_t_ptr options,
            size_t write_buffer_size);

        public abstract void rocksdb_options_set_db_write_buffer_size(
            rocksdb_options_t_ptr options,
            size_t db_write_buffer_size);

        public abstract void rocksdb_options_set_max_open_files(
            rocksdb_options_t_ptr options,
            int max_open_files);

        public abstract void rocksdb_options_set_max_file_opening_threads(
            rocksdb_options_t_ptr options,
            int max_file_opening_threads);

        public abstract void rocksdb_options_set_max_total_wal_size(
            rocksdb_options_t_ptr opt,
            uint64_t n);

        public abstract void rocksdb_options_set_compression_options(
            rocksdb_options_t_ptr options,
            int p1,
            int p2,
            int p3,
            int p4);

        public abstract void rocksdb_options_set_prefix_extractor(
            rocksdb_options_t_ptr options,
            rocksdb_slicetransform_t_ptr prefix_extractor);

        public abstract void rocksdb_options_set_num_levels(
            rocksdb_options_t_ptr options,
            int num_levels);

        public abstract void rocksdb_options_set_level0_file_num_compaction_trigger(
            rocksdb_options_t_ptr options,
            int level0_file_num_compaction_trigger);

        public abstract void rocksdb_options_set_level0_slowdown_writes_trigger(
            rocksdb_options_t_ptr options,
            int level0_slowdown_writes_trigger);

        public abstract void rocksdb_options_set_level0_stop_writes_trigger(
            rocksdb_options_t_ptr options,
            int level0_stop_writes_trigger);

        public abstract void rocksdb_options_set_max_mem_compaction_level(
            rocksdb_options_t_ptr options,
            int max_mem_compaction_level);

        public abstract void rocksdb_options_set_target_file_size_base(
            rocksdb_options_t_ptr options,
            uint64_t target_file_size_base);

        public abstract void rocksdb_options_set_target_file_size_multiplier(
            rocksdb_options_t_ptr options,
            int target_file_size_multiplier);

        public abstract void rocksdb_options_set_max_bytes_for_level_base(
            rocksdb_options_t_ptr options,
            uint64_t max_bytes_for_level_base);

        public abstract void rocksdb_options_set_level_compaction_dynamic_level_bytes(
            rocksdb_options_t_ptr options,
            unsigned_char level_compaction_dynamic_level_bytes);

        public abstract void rocksdb_options_set_max_bytes_for_level_multiplier(
            rocksdb_options_t_ptr options,
            double max_bytes_for_level_multiplier);

        public abstract void rocksdb_options_set_max_bytes_for_level_multiplier_additional(
            rocksdb_options_t_ptr options,
            int_ptr level_values,
            size_t num_levels);

        public abstract void rocksdb_options_set_max_bytes_for_level_multiplier_additional(
            rocksdb_options_t_ptr options,
            int[] level_values,
            size_t num_levels);

        public abstract void rocksdb_options_enable_statistics(
            rocksdb_options_t_ptr options);

        public abstract void rocksdb_options_set_skip_stats_update_on_db_open(
            rocksdb_options_t_ptr opt,
            unsigned_char val);

        /* returns a pointer to a malloc()-ed, null terminated string */
        public abstract char_ptr rocksdb_options_statistics_get_string(
            rocksdb_options_t_ptr opt);

        public abstract void rocksdb_options_set_max_write_buffer_number(
            rocksdb_options_t_ptr options,
            int max_write_buffer_number);

        public abstract void rocksdb_options_set_min_write_buffer_number_to_merge(
            rocksdb_options_t_ptr options,
            int min_write_buffer_number_to_merge);

        public abstract void rocksdb_options_set_max_write_buffer_number_to_maintain(
            rocksdb_options_t_ptr options,
            int max_write_buffer_number_to_maintain);

        public abstract void rocksdb_options_set_max_background_compactions(
            rocksdb_options_t_ptr options,
            int max_background_compactions);

        public abstract void rocksdb_options_set_base_background_compactions(
            rocksdb_options_t_ptr options,
            int base_background_compactions);

        public abstract void rocksdb_options_set_max_background_flushes(
            rocksdb_options_t_ptr options,
            int max_background_flushes);

        public abstract void rocksdb_options_set_max_log_file_size(
            rocksdb_options_t_ptr options,
            size_t max_log_file_size);

        public abstract void rocksdb_options_set_log_file_time_to_roll(
            rocksdb_options_t_ptr options,
            size_t log_file_time_to_roll);

        public abstract void rocksdb_options_set_keep_log_file_num(
            rocksdb_options_t_ptr options,
            size_t keep_log_file_num);

        public abstract void rocksdb_options_set_recycle_log_file_num(
            rocksdb_options_t_ptr options,
            size_t recycle_log_file_num);

        public abstract void rocksdb_options_set_soft_rate_limit(
            rocksdb_options_t_ptr options,
            double soft_rate_limit);

        public abstract void rocksdb_options_set_hard_rate_limit(
            rocksdb_options_t_ptr options,
            double hard_rate_limit);

        public abstract void rocksdb_options_set_soft_pending_compaction_bytes_limit(
            rocksdb_options_t_ptr opt,
            size_t v);

        public abstract void rocksdb_options_set_hard_pending_compaction_bytes_limit(
            rocksdb_options_t_ptr opt,
            size_t v);

        public abstract void rocksdb_options_set_rate_limit_delay_max_milliseconds(
            rocksdb_options_t_ptr options,
            unsigned_int rate_limit_delay_max_milliseconds);

        public abstract void rocksdb_options_set_max_manifest_file_size(
            rocksdb_options_t_ptr options,
            size_t max_manifest_file_size);

        public abstract void rocksdb_options_set_table_cache_numshardbits(
            rocksdb_options_t_ptr options,
            int table_cache_numshardbits);

        public abstract void rocksdb_options_set_table_cache_remove_scan_count_limit(
            rocksdb_options_t_ptr options,
            int table_cache_remove_scan_count_limit);

        public abstract void rocksdb_options_set_arena_block_size(
            rocksdb_options_t_ptr options,
            size_t arena_block_size);

        public abstract void rocksdb_options_set_use_fsync(
            rocksdb_options_t_ptr options,
            int use_fsync);

        public abstract void rocksdb_options_set_db_log_dir(
            rocksdb_options_t_ptr options,
            const_char_ptr db_log_dir);

        public abstract void rocksdb_options_set_db_log_dir(
            rocksdb_options_t_ptr options,
            string db_log_dir);

        public abstract void rocksdb_options_set_wal_dir(
            rocksdb_options_t_ptr options,
            const_char_ptr wal_dir);

        public abstract void rocksdb_options_set_wal_dir(
            rocksdb_options_t_ptr options,
            string wal_dir);

        public abstract void rocksdb_options_set_WAL_ttl_seconds(
            rocksdb_options_t_ptr options,
            uint64_t WAL_ttl_seconds);

        public abstract void rocksdb_options_set_WAL_size_limit_MB(
            rocksdb_options_t_ptr options,
            uint64_t WAL_size_limit_MB);

        public abstract void rocksdb_options_set_manifest_preallocation_size(
            rocksdb_options_t_ptr options,
            size_t manifest_preallocation_size);

        public abstract void rocksdb_options_set_purge_redundant_kvs_while_flush(
            rocksdb_options_t_ptr options,
            unsigned_char purge_redundant_kvs_while_flush);

        public abstract void rocksdb_options_set_allow_mmap_reads(
            rocksdb_options_t_ptr options,
            unsigned_char allow_mmap_reads);

        public abstract void rocksdb_options_set_allow_mmap_writes(
            rocksdb_options_t_ptr options,
            unsigned_char allow_mmap_writes);

        public abstract void rocksdb_options_set_use_direct_reads(
            rocksdb_options_t_ptr options,
            unsigned_char use_direct_reads);

        public abstract void rocksdb_options_set_use_direct_io_for_flush_and_compaction(
            rocksdb_options_t_ptr options,
            unsigned_char use_direct_io_for_flush_and_compaction);

        public abstract void rocksdb_options_set_is_fd_close_on_exec(
            rocksdb_options_t_ptr options,
            unsigned_char is_fd_close_on_exec);

        public abstract void rocksdb_options_set_skip_log_error_on_recovery(
            rocksdb_options_t_ptr options,
            unsigned_char skip_log_error_on_recovery);

        public abstract void rocksdb_options_set_stats_dump_period_sec(
            rocksdb_options_t_ptr options,
            unsigned_int stats_dump_period_sec);

        public abstract void rocksdb_options_set_advise_random_on_open(
            rocksdb_options_t_ptr options,
            unsigned_char advise_random_on_open);

        public abstract void rocksdb_options_set_access_hint_on_compaction_start(
            rocksdb_options_t_ptr options,
            int access_hint_on_compaction_start);

        public abstract void rocksdb_options_set_use_adaptive_mutex(
            rocksdb_options_t_ptr options,
            unsigned_char use_adaptive_mutex);

        public abstract void rocksdb_options_set_bytes_per_sync(
            rocksdb_options_t_ptr options,
            uint64_t bytes_per_sync);

        public abstract void rocksdb_options_set_allow_concurrent_memtable_write(
            rocksdb_options_t_ptr options,
            unsigned_char allow_concurrent_memtable_write);

        public abstract void rocksdb_options_set_enable_write_thread_adaptive_yield(
            rocksdb_options_t_ptr options,
            unsigned_char enable_write_thread_adaptive_yield);

        public abstract void rocksdb_options_set_max_sequential_skip_in_iterations(
            rocksdb_options_t_ptr options,
            uint64_t max_sequential_skip_in_iterations);

        public abstract void rocksdb_options_set_disable_auto_compactions(
            rocksdb_options_t_ptr options,
            int disable_auto_compactions);

        public abstract void rocksdb_options_set_optimize_filters_for_hits(
            rocksdb_options_t_ptr options,
            int optimize_filters_for_hits);

        public abstract void rocksdb_options_set_delete_obsolete_files_period_micros(
            rocksdb_options_t_ptr options,
            uint64_t delete_obsolete_files_period_micros);

        public abstract void rocksdb_options_prepare_for_bulk_load(
            rocksdb_options_t_ptr options);

        public abstract void rocksdb_options_set_memtable_vector_rep(
            rocksdb_options_t_ptr options);

        public abstract void rocksdb_options_set_memtable_prefix_bloom_size_ratio(
            rocksdb_options_t_ptr options,
            double memtable_prefix_bloom_size_ratio);

        public abstract void rocksdb_options_set_max_compaction_bytes(
            rocksdb_options_t_ptr options,
            uint64_t max_compaction_bytes);

        public abstract void rocksdb_options_set_hash_skip_list_rep(
            rocksdb_options_t_ptr options,
            size_t size,
            int32_t p2,
            int32_t p3);

        public abstract void rocksdb_options_set_hash_link_list_rep(
            rocksdb_options_t_ptr options,
            size_t hash_link_list_rep);

        public abstract void rocksdb_options_set_plain_table_factory(
            rocksdb_options_t_ptr options,
            uint32_t p1,
            int p2,
            double p3,
            size_t size);

        public abstract void rocksdb_options_set_min_level_to_compress(
            rocksdb_options_t_ptr opt,
            int level);

        public abstract void rocksdb_options_set_memtable_huge_page_size(
            rocksdb_options_t_ptr options,
            size_t memtable_huge_page_size);

        public abstract void rocksdb_options_set_max_successive_merges(
            rocksdb_options_t_ptr options,
            size_t max_successive_merges);

        public abstract void rocksdb_options_set_bloom_locality(
            rocksdb_options_t_ptr options,
            uint32_t bloom_locality);

        public abstract void rocksdb_options_set_inplace_update_support(
            rocksdb_options_t_ptr options,
            unsigned_char inplace_update_support);

        public abstract void rocksdb_options_set_inplace_update_num_locks(
            rocksdb_options_t_ptr options,
            size_t inplace_update_num_locks);

        public abstract void rocksdb_options_set_report_bg_io_stats(
            rocksdb_options_t_ptr options,
            int report_bg_io_stats);

        public abstract void rocksdb_options_set_wal_recovery_mode(
            rocksdb_options_t_ptr options,
            Recovery wal_recovery_mode);

        public abstract void rocksdb_options_set_compression(
            rocksdb_options_t_ptr options,
            Compression compression);

        public abstract void rocksdb_options_set_compaction_style(
            rocksdb_options_t_ptr options,
            Compaction compaction_style);

        public abstract void rocksdb_options_set_universal_compaction_options(
            rocksdb_options_t_ptr options,
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options);

        public abstract void rocksdb_options_set_fifo_compaction_options(
            rocksdb_options_t_ptr opt,
            rocksdb_fifo_compaction_options_t_ptr fifo);

        public abstract void rocksdb_options_set_ratelimiter(
            rocksdb_options_t_ptr opt,
            rocksdb_ratelimiter_t_ptr limiter);

    } // class Native
    #endregion // Options
    #region RateLimiter
    public partial class Native
    {
        public abstract rocksdb_ratelimiter_t_ptr rocksdb_ratelimiter_create(
            int64_t rate_bytes_per_sec,
            int64_t refill_period_us,
            int32_t fairness);

        public abstract void rocksdb_ratelimiter_destroy(
            rocksdb_ratelimiter_t_ptr ratelimiter);

    } // class Native
    #endregion // RateLimiter
    #region Compaction Filter
    public partial class Native
    {
        public abstract rocksdb_compactionfilter_t_ptr rocksdb_compactionfilter_create(
            void_ptr state,
            DestructorDelegate destructor,
            FilterDelegate filter,
            NameDelegate name);

        public abstract void rocksdb_compactionfilter_set_ignore_snapshots(
            rocksdb_compactionfilter_t_ptr compactionfilter,
            unsigned_char p1);

        public abstract void rocksdb_compactionfilter_destroy(
            rocksdb_compactionfilter_t_ptr compactionfilter);

    } // class Native
    #endregion // Compaction Filter
    #region Compaction Filter Context
    public partial class Native
    {
        public abstract unsigned_char rocksdb_compactionfiltercontext_is_full_compaction(
            rocksdb_compactionfiltercontext_t_ptr context);

        public abstract unsigned_char rocksdb_compactionfiltercontext_is_manual_compaction(
            rocksdb_compactionfiltercontext_t_ptr context);

    } // class Native
    #endregion // Compaction Filter Context
    #region Compaction Filter Factory
    public partial class Native
    {
        public abstract rocksdb_compactionfilterfactory_t_ptr rocksdb_compactionfilterfactory_create(
            void_ptr state,
            DestructorDelegate destructor,
            CreateCompactionFilterDelegate create_compaction_filter,
            NameDelegate name);

        public abstract void rocksdb_compactionfilterfactory_destroy(
            rocksdb_compactionfilterfactory_t_ptr compactionfilterfactory);

    } // class Native
    #endregion // Compaction Filter Factory
    #region Comparator
    public partial class Native
    {
        public abstract rocksdb_comparator_t_ptr rocksdb_comparator_create(
            void_ptr state,
            DestructorDelegate destructor,
            CompareDelegate compare,
            NameDelegate name);

        public abstract void rocksdb_comparator_destroy(
            rocksdb_comparator_t_ptr comparator);

    } // class Native
    #endregion // Comparator
    #region Filter policy
    public partial class Native
    {
        public abstract rocksdb_filterpolicy_t_ptr rocksdb_filterpolicy_create(
            void_ptr state,
            DestructorDelegate destructor,
            CreateFilterDelegate create_filter,
            KeyMayMatchDelegate key_may_match,
            DeleteFilterDelegate delete_filter,
            NameDelegate name);

        public abstract void rocksdb_filterpolicy_destroy(
            rocksdb_filterpolicy_t_ptr filterpolicy);

        public abstract rocksdb_filterpolicy_t_ptr rocksdb_filterpolicy_create_bloom(
            int bits_per_key);

        public abstract rocksdb_filterpolicy_t_ptr rocksdb_filterpolicy_create_bloom_full(
            int bits_per_key);

    } // class Native
    #endregion // Filter policy
    #region Merge Operator
    public partial class Native
    {
        public abstract rocksdb_mergeoperator_t_ptr rocksdb_mergeoperator_create(
            void_ptr state,
            DestructorDelegate destructor,
            FullMergeDelegate full_merge,
            PartialMergeDelegate partial_merge,
            DeleteValueDelegate delete_value,
            NameDelegate name);

        public abstract void rocksdb_mergeoperator_destroy(
            rocksdb_mergeoperator_t_ptr mergeoperator);

    } // class Native
    #endregion // Merge Operator
    #region Read options
    public partial class Native
    {
        public abstract rocksdb_readoptions_t_ptr rocksdb_readoptions_create();

        public abstract void rocksdb_readoptions_destroy(
            rocksdb_readoptions_t_ptr readoptions);

        public abstract void rocksdb_readoptions_set_verify_checksums(
            rocksdb_readoptions_t_ptr readoptions,
            unsigned_char verify_checksums);

        public abstract void rocksdb_readoptions_set_fill_cache(
            rocksdb_readoptions_t_ptr readoptions,
            unsigned_char fill_cache);

        public abstract void rocksdb_readoptions_set_snapshot(
            rocksdb_readoptions_t_ptr readoptions,
            const_rocksdb_snapshot_t_ptr snapshot);

        public abstract void rocksdb_readoptions_set_iterate_upper_bound(
            rocksdb_readoptions_t_ptr readoptions,
            const_char_ptr key,
            size_t keylen);

        public unsafe abstract void rocksdb_readoptions_set_iterate_upper_bound(
            rocksdb_readoptions_t_ptr readoptions,
            byte* key,
            size_t keylen);

        public abstract void rocksdb_readoptions_set_iterate_upper_bound(
            rocksdb_readoptions_t_ptr readoptions,
            byte[] key,
            size_t keylen);

        public abstract void rocksdb_readoptions_set_read_tier(
            rocksdb_readoptions_t_ptr readoptions,
            int read_tier);

        public abstract void rocksdb_readoptions_set_tailing(
            rocksdb_readoptions_t_ptr readoptions,
            unsigned_char tailing);

        public abstract void rocksdb_readoptions_set_readahead_size(
            rocksdb_readoptions_t_ptr readoptions,
            size_t readahead_size);

        public abstract void rocksdb_readoptions_set_pin_data(
            rocksdb_readoptions_t_ptr readoptions,
            unsigned_char pin_data);

        public abstract void rocksdb_readoptions_set_total_order_seek(
            rocksdb_readoptions_t_ptr readoptions,
            unsigned_char total_order_seek);

    } // class Native
    #endregion // Read options
    #region Write options
    public partial class Native
    {
        public abstract rocksdb_writeoptions_t_ptr rocksdb_writeoptions_create();

        public abstract void rocksdb_writeoptions_destroy(
            rocksdb_writeoptions_t_ptr writeoptions);

        public abstract void rocksdb_writeoptions_set_sync(
            rocksdb_writeoptions_t_ptr writeoptions,
            unsigned_char sync);

        public abstract void rocksdb_writeoptions_disable_WAL(
            rocksdb_writeoptions_t_ptr opt,
            int disable);

    } // class Native
    #endregion // Write options
    #region Compact range options
    public partial class Native
    {
        public abstract rocksdb_compactoptions_t_ptr rocksdb_compactoptions_create();

        public abstract void rocksdb_compactoptions_destroy(
            rocksdb_compactoptions_t_ptr compactoptions);

        public abstract void rocksdb_compactoptions_set_exclusive_manual_compaction(
            rocksdb_compactoptions_t_ptr compactoptions,
            unsigned_char exclusive_manual_compaction);

        public abstract void rocksdb_compactoptions_set_change_level(
            rocksdb_compactoptions_t_ptr compactoptions,
            unsigned_char change_level);

        public abstract void rocksdb_compactoptions_set_target_level(
            rocksdb_compactoptions_t_ptr compactoptions,
            int target_level);

    } // class Native
    #endregion // Compact range options
    #region Flush options
    public partial class Native
    {
        public abstract rocksdb_flushoptions_t_ptr rocksdb_flushoptions_create();

        public abstract void rocksdb_flushoptions_destroy(
            rocksdb_flushoptions_t_ptr flushoptions);

        public abstract void rocksdb_flushoptions_set_wait(
            rocksdb_flushoptions_t_ptr flushoptions,
            unsigned_char wait);

    } // class Native
    #endregion // Flush options
    #region Cache
    public partial class Native
    {
        public abstract rocksdb_cache_t_ptr rocksdb_cache_create_lru(
            size_t capacity);

        public abstract void rocksdb_cache_destroy(
            rocksdb_cache_t_ptr cache);

        public abstract void rocksdb_cache_set_capacity(
            rocksdb_cache_t_ptr cache,
            size_t capacity);

        public abstract size_t rocksdb_cache_get_usage(
            rocksdb_cache_t_ptr cache);

        public abstract size_t rocksdb_cache_get_pinned_usage(
            rocksdb_cache_t_ptr cache);

    } // class Native
    #endregion // Cache
    #region DBPath
    public partial class Native
    {
        public abstract rocksdb_dbpath_t_ptr rocksdb_dbpath_create(
            const_char_ptr path,
            uint64_t target_size);

        public abstract rocksdb_dbpath_t_ptr rocksdb_dbpath_create(
            string path,
            uint64_t target_size);

        public abstract void rocksdb_dbpath_destroy(
            rocksdb_dbpath_t_ptr dbpath);

    } // class Native
    #endregion // DBPath
    #region Env
    public partial class Native
    {
        public abstract rocksdb_env_t_ptr rocksdb_create_default_env();

        public abstract rocksdb_env_t_ptr rocksdb_create_mem_env();

        public abstract void rocksdb_env_set_background_threads(
            rocksdb_env_t_ptr env,
            int n);

        public abstract void rocksdb_env_set_high_priority_background_threads(
            rocksdb_env_t_ptr env,
            int n);

        public abstract void rocksdb_env_join_all_threads(
            rocksdb_env_t_ptr env);

        public abstract void rocksdb_env_destroy(
            rocksdb_env_t_ptr env);

        public abstract rocksdb_envoptions_t_ptr rocksdb_envoptions_create();

        public abstract void rocksdb_envoptions_destroy(
            rocksdb_envoptions_t_ptr opt);

    } // class Native
    #endregion // Env
    #region SstFile
    public partial class Native
    {
        public abstract rocksdb_sstfilewriter_t_ptr rocksdb_sstfilewriter_create(
            const_rocksdb_envoptions_t_ptr env,
            const_rocksdb_options_t_ptr io_options);

        public abstract rocksdb_sstfilewriter_t_ptr rocksdb_sstfilewriter_create_with_comparator(
            const_rocksdb_envoptions_t_ptr env,
            const_rocksdb_options_t_ptr io_options,
            const_rocksdb_comparator_t_ptr comparator);

        public abstract void rocksdb_sstfilewriter_open(
            rocksdb_sstfilewriter_t_ptr writer,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_open(
            rocksdb_sstfilewriter_t_ptr writer,
            string name,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_add(
            rocksdb_sstfilewriter_t_ptr writer,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_sstfilewriter_add(
            rocksdb_sstfilewriter_t_ptr writer,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_add(
            rocksdb_sstfilewriter_t_ptr writer,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_put(
            rocksdb_sstfilewriter_t_ptr writer,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_sstfilewriter_put(
            rocksdb_sstfilewriter_t_ptr writer,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_put(
            rocksdb_sstfilewriter_t_ptr writer,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_merge(
            rocksdb_sstfilewriter_t_ptr writer,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_sstfilewriter_merge(
            rocksdb_sstfilewriter_t_ptr writer,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_merge(
            rocksdb_sstfilewriter_t_ptr writer,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_delete(
            rocksdb_sstfilewriter_t_ptr writer,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_sstfilewriter_delete(
            rocksdb_sstfilewriter_t_ptr writer,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_delete(
            rocksdb_sstfilewriter_t_ptr writer,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_finish(
            rocksdb_sstfilewriter_t_ptr writer,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_sstfilewriter_destroy(
            rocksdb_sstfilewriter_t_ptr writer);

        public abstract rocksdb_ingestexternalfileoptions_t_ptr rocksdb_ingestexternalfileoptions_create();

        public abstract void rocksdb_ingestexternalfileoptions_set_move_files(
            rocksdb_ingestexternalfileoptions_t_ptr opt,
            unsigned_char move_files);

        public abstract void rocksdb_ingestexternalfileoptions_set_snapshot_consistency(
            rocksdb_ingestexternalfileoptions_t_ptr opt,
            unsigned_char snapshot_consistency);

        public abstract void rocksdb_ingestexternalfileoptions_set_allow_global_seqno(
            rocksdb_ingestexternalfileoptions_t_ptr opt,
            unsigned_char allow_global_seqno);

        public abstract void rocksdb_ingestexternalfileoptions_set_allow_blocking_flush(
            rocksdb_ingestexternalfileoptions_t_ptr opt,
            unsigned_char allow_blocking_flush);

        public abstract void rocksdb_ingestexternalfileoptions_destroy(
            rocksdb_ingestexternalfileoptions_t_ptr opt);

        public abstract void rocksdb_ingest_external_file(
            rocksdb_t_ptr db,
            string[] file_list,
            const_size_t list_len,
            const_rocksdb_ingestexternalfileoptions_t_ptr opt,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_ingest_external_file(
            rocksdb_t_ptr db,
            IntPtr[] file_list,
            const_size_t list_len,
            const_rocksdb_ingestexternalfileoptions_t_ptr opt,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_ingest_external_file_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr handle,
            string[] file_list,
            const_size_t list_len,
            const_rocksdb_ingestexternalfileoptions_t_ptr opt,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_ingest_external_file_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr handle,
            IntPtr[] file_list,
            const_size_t list_len,
            const_rocksdb_ingestexternalfileoptions_t_ptr opt,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // SstFile
    #region SliceTransform
    public partial class Native
    {
        public abstract rocksdb_slicetransform_t_ptr rocksdb_slicetransform_create(
            void_ptr state,
            DestructorDelegate destructor,
            TransformDelegate transform,
            InDomainDelegate in_domain,
            InRangeDelegate in_range,
            NameDelegate name);

        public abstract rocksdb_slicetransform_t_ptr rocksdb_slicetransform_create_fixed_prefix(
            size_t size);

        public abstract rocksdb_slicetransform_t_ptr rocksdb_slicetransform_create_noop();

        public abstract void rocksdb_slicetransform_destroy(
            rocksdb_slicetransform_t_ptr slicetransform);

    } // class Native
    #endregion // SliceTransform
    #region Universal Compaction options

    public enum SizeCompactionStopStyle
    {
        Similar = 0,
        Total = 1,
    }

    public partial class Native
    {
        public abstract rocksdb_universal_compaction_options_t_ptr rocksdb_universal_compaction_options_create();

        public abstract void rocksdb_universal_compaction_options_set_size_ratio(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int size_ratio);

        public abstract void rocksdb_universal_compaction_options_set_min_merge_width(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int min_merge_width);

        public abstract void rocksdb_universal_compaction_options_set_max_merge_width(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int max_merge_width);

        public abstract void rocksdb_universal_compaction_options_set_max_size_amplification_percent(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int max_size_amplification_percent);

        public abstract void rocksdb_universal_compaction_options_set_compression_size_percent(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int compression_size_percent);

        public abstract void rocksdb_universal_compaction_options_set_stop_style(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options,
            int stop_style);

        public abstract void rocksdb_universal_compaction_options_destroy(
            rocksdb_universal_compaction_options_t_ptr universal_compaction_options);

        public abstract rocksdb_fifo_compaction_options_t_ptr rocksdb_fifo_compaction_options_create();

        public abstract void rocksdb_fifo_compaction_options_set_max_table_files_size(
            rocksdb_fifo_compaction_options_t_ptr fifo_opts,
            uint64_t size);

        public abstract void rocksdb_fifo_compaction_options_destroy(
            rocksdb_fifo_compaction_options_t_ptr fifo_opts);

        public abstract int rocksdb_livefiles_count(
            const_rocksdb_livefiles_t_ptr livefiles);

        public abstract const_char_ptr rocksdb_livefiles_name(
            const_rocksdb_livefiles_t_ptr livefiles,
            int index);

        public abstract int rocksdb_livefiles_level(
            const_rocksdb_livefiles_t_ptr livefiles,
            int index);

        public abstract size_t rocksdb_livefiles_size(
            const_rocksdb_livefiles_t_ptr livefiles,
            int index);

        public abstract const_char_ptr rocksdb_livefiles_smallestkey(
            const_rocksdb_livefiles_t_ptr livefiles,
            int index,
            out size_t size);

        public abstract const_char_ptr rocksdb_livefiles_largestkey(
            const_rocksdb_livefiles_t_ptr livefiles,
            int index,
            out size_t size);

        public abstract void rocksdb_livefiles_destroy(
            const_rocksdb_livefiles_t_ptr livefiles);

    } // class Native
    #endregion // Universal Compaction options
    #region Utility Helpers
    public partial class Native
    {
        public abstract void rocksdb_get_options_from_string(
            const_rocksdb_options_t_ptr base_options,
            const_char_ptr opts_str,
            rocksdb_options_t_ptr new_options,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_file_in_range(
            rocksdb_t_ptr db,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_delete_file_in_range(
            rocksdb_t_ptr db,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_file_in_range(
            rocksdb_t_ptr db,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_file_in_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr start_key,
            size_t start_key_len,
            const_char_ptr limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_delete_file_in_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* start_key,
            size_t start_key_len,
            byte* limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_delete_file_in_range_cf(
            rocksdb_t_ptr db,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] start_key,
            size_t start_key_len,
            byte[] limit_key,
            size_t limit_key_len,
            out char_ptr_ptr errptr);

    } // class Native
    #endregion // Utility Helpers
    #region Transactions
    public partial class Native
    {
        public abstract rocksdb_column_family_handle_t_ptr rocksdb_transactiondb_create_column_family(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_options_t_ptr column_family_options,
            const_char_ptr column_family_name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_column_family_handle_t_ptr rocksdb_transactiondb_create_column_family(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_options_t_ptr column_family_options,
            string column_family_name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_transactiondb_t_ptr rocksdb_transactiondb_open(
            const_rocksdb_options_t_ptr options,
            const_rocksdb_transactiondb_options_t_ptr txn_db_options,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_transactiondb_t_ptr rocksdb_transactiondb_open(
            const_rocksdb_options_t_ptr options,
            const_rocksdb_transactiondb_options_t_ptr txn_db_options,
            string name,
            out char_ptr_ptr errptr);

        public abstract const_rocksdb_snapshot_t_ptr rocksdb_transactiondb_create_snapshot(
            rocksdb_transactiondb_t_ptr txn_db);

        public abstract void rocksdb_transactiondb_release_snapshot(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_snapshot_t_ptr snapshot);

        public abstract rocksdb_transaction_t_ptr rocksdb_transaction_begin(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr write_options,
            const_rocksdb_transaction_options_t_ptr txn_options,
            rocksdb_transaction_t_ptr old_txn);

        public abstract void rocksdb_transaction_commit(
            rocksdb_transaction_t_ptr txn,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_rollback(
            rocksdb_transaction_t_ptr txn,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_destroy(
            rocksdb_transaction_t_ptr txn);

        // This snapshot should be freed using rocksdb_free
        public abstract const_rocksdb_snapshot_t_ptr rocksdb_transaction_get_snapshot(
            rocksdb_transaction_t_ptr txn);

        public abstract char_ptr rocksdb_transaction_get(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_transaction_get(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transaction_get(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transaction_get_cf(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_transaction_get_cf(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transaction_get_cf(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transaction_get_for_update(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            out size_t vlen,
            unsigned_char exclusive,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_transaction_get_for_update(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t klen,
            out size_t vlen,
            unsigned_char exclusive,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transaction_get_for_update(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t klen,
            out size_t vlen,
            unsigned_char exclusive,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transactiondb_get(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_transactiondb_get(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transactiondb_get(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t klen,
            out size_t vlen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transactiondb_get_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract char_ptr rocksdb_transactiondb_get_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract char_ptr rocksdb_transactiondb_get_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_put(
            rocksdb_transaction_t_ptr txn,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transaction_put(
            rocksdb_transaction_t_ptr txn,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_put(
            rocksdb_transaction_t_ptr txn,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_put_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transaction_put_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_put_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_put(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transactiondb_put(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_put(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_put_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            const_char_ptr val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transactiondb_put_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            byte* val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_put_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            byte[] val,
            size_t vallen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_write(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_writebatch_t_ptr batch,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_merge(
            rocksdb_transaction_t_ptr txn,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transaction_merge(
            rocksdb_transaction_t_ptr txn,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_merge(
            rocksdb_transaction_t_ptr txn,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_merge(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            const_char_ptr val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transactiondb_merge(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t klen,
            byte* val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_merge(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t klen,
            byte[] val,
            size_t vlen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_delete(
            rocksdb_transaction_t_ptr txn,
            const_char_ptr key,
            size_t klen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transaction_delete(
            rocksdb_transaction_t_ptr txn,
            byte* key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_delete(
            rocksdb_transaction_t_ptr txn,
            byte[] key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_delete_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t klen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transaction_delete_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transaction_delete_cf(
            rocksdb_transaction_t_ptr txn,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_delete(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            const_char_ptr key,
            size_t klen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transactiondb_delete(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte* key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_delete(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            byte[] key,
            size_t klen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_delete_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract void rocksdb_transactiondb_delete_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_transactiondb_delete_cf(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_writeoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract rocksdb_iterator_t_ptr rocksdb_transaction_create_iterator(
            rocksdb_transaction_t_ptr txn,
            const_rocksdb_readoptions_t_ptr options);

        public abstract rocksdb_iterator_t_ptr rocksdb_transactiondb_create_iterator(
            rocksdb_transactiondb_t_ptr txn_db,
            const_rocksdb_readoptions_t_ptr options);

        public abstract void rocksdb_transactiondb_close(
            rocksdb_transactiondb_t_ptr txn_db);

        public abstract rocksdb_checkpoint_t_ptr rocksdb_transactiondb_checkpoint_object_create(
            rocksdb_transactiondb_t_ptr txn_db,
            out char_ptr_ptr errptr);

        public abstract rocksdb_optimistictransactiondb_t_ptr rocksdb_optimistictransactiondb_open(
            const_rocksdb_options_t_ptr options,
            const_char_ptr name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_optimistictransactiondb_t_ptr rocksdb_optimistictransactiondb_open(
            const_rocksdb_options_t_ptr options,
            string name,
            out char_ptr_ptr errptr);

        public abstract rocksdb_transaction_t_ptr rocksdb_optimistictransaction_begin(
            rocksdb_optimistictransactiondb_t_ptr otxn_db,
            const_rocksdb_writeoptions_t_ptr write_options,
            const_rocksdb_optimistictransaction_options_t_ptr otxn_options,
            rocksdb_transaction_t_ptr old_txn);

        public abstract void rocksdb_optimistictransactiondb_close(
            rocksdb_optimistictransactiondb_t_ptr otxn_db);

    } // class Native
    #endregion // Transactions
    #region Transaction Options
    public partial class Native
    {
        public abstract rocksdb_transactiondb_options_t_ptr rocksdb_transactiondb_options_create();

        public abstract void rocksdb_transactiondb_options_destroy(
            rocksdb_transactiondb_options_t_ptr opt);

        public abstract void rocksdb_transactiondb_options_set_max_num_locks(
            rocksdb_transactiondb_options_t_ptr opt,
            int64_t max_num_locks);

        public abstract void rocksdb_transactiondb_options_set_num_stripes(
            rocksdb_transactiondb_options_t_ptr opt,
            size_t num_stripes);

        public abstract void rocksdb_transactiondb_options_set_transaction_lock_timeout(
            rocksdb_transactiondb_options_t_ptr opt,
            int64_t txn_lock_timeout);

        public abstract void rocksdb_transactiondb_options_set_default_lock_timeout(
            rocksdb_transactiondb_options_t_ptr opt,
            int64_t default_lock_timeout);

        public abstract rocksdb_transaction_options_t_ptr rocksdb_transaction_options_create();

        public abstract void rocksdb_transaction_options_destroy(
            rocksdb_transaction_options_t_ptr opt);

        public abstract void rocksdb_transaction_options_set_set_snapshot(
            rocksdb_transaction_options_t_ptr opt,
            unsigned_char v);

        public abstract void rocksdb_transaction_options_set_deadlock_detect(
            rocksdb_transaction_options_t_ptr opt,
            unsigned_char v);

        public abstract void rocksdb_transaction_options_set_lock_timeout(
            rocksdb_transaction_options_t_ptr opt,
            int64_t lock_timeout);

        public abstract void rocksdb_transaction_options_set_expiration(
            rocksdb_transaction_options_t_ptr opt,
            int64_t expiration);

        public abstract void rocksdb_transaction_options_set_deadlock_detect_depth(
            rocksdb_transaction_options_t_ptr opt,
            int64_t depth);

        public abstract void rocksdb_transaction_options_set_max_write_batch_size(
            rocksdb_transaction_options_t_ptr opt,
            size_t size);

        public abstract rocksdb_optimistictransaction_options_t_ptr rocksdb_optimistictransaction_options_create();

        public abstract void rocksdb_optimistictransaction_options_destroy(
            rocksdb_optimistictransaction_options_t_ptr opt);

        public abstract void rocksdb_optimistictransaction_options_set_set_snapshot(
            rocksdb_optimistictransaction_options_t_ptr opt,
            unsigned_char v);

        // referring to convention (3), this should be used by client
        // to free memory that was malloc()ed
        public abstract void rocksdb_free(
            void_ptr ptr);

        public abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            const_char_ptr key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public unsafe abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte* key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract rocksdb_pinnableslice_t_ptr rocksdb_get_pinned_cf(
            rocksdb_t_ptr db,
            const_rocksdb_readoptions_t_ptr options,
            rocksdb_column_family_handle_t_ptr column_family,
            byte[] key,
            size_t keylen,
            out char_ptr_ptr errptr);

        public abstract void rocksdb_pinnableslice_destroy(
            rocksdb_pinnableslice_t_ptr v);

        public abstract const_char_ptr rocksdb_pinnableslice_value(
            const_rocksdb_pinnableslice_t_ptr t,
            out size_t vlen);

    } // class Native
    #endregion // Transaction Options
} // namespace RocksDbSharp