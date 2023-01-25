import input_d
import export_d
import import_d
import operations_history as h

def start():
    if input_d.operation() == '1':
        info = input_d.data_export()
        export_d.export(info)
        h.history(info)
    else:
        info = input_d.data_import()
        import_d.imp_d(info)
        h.history(info)