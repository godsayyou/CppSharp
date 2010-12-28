// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Wrappers {
    using System;
    using System.Runtime.InteropServices;
    using Mono.VisualC.Interop;
    
    public class QItemDelegate : QAbstractItemDelegate {
        private static IQItemDelegate impl = Wrappers.Libs.Lib.GetClass <IQItemDelegate, _QItemDelegate, QItemDelegate>("QItemDelegate");
        public QItemDelegate(QObject parent) {
            impl.QItemDelegate(this.Native, parent);
        }
        public bool HasClipping {
            get {
                return impl.hasClipping(this.Native);
            }
        }
        public QItemEditorFactory ItemEditorFactory {
            get {
                return impl.itemEditorFactory(this.Native);
            }
            set {
                impl.setItemEditorFactory(this.Native, value);
            }
        }
        public override void Dispose() {
        }
        public void SetClipping(bool clip) {
            impl.setClipping(this.Native, clip);
        }
        public interface IQItemDelegate : ICppClassOverridable<QItemDelegate> {
            [Constructor()]
            void QItemDelegate(CppInstancePtr @this, [MangleAs("class QObject *")] QObject parent);
            [Virtual()]
            [Destructor()]
            void Destruct(CppInstancePtr @this);
            [Const()]
            bool hasClipping(CppInstancePtr @this);
            void setClipping(CppInstancePtr @this, [MangleAs("bool")] bool clip);
            [Const()]
            QItemEditorFactory itemEditorFactory(CppInstancePtr @this);
            void setItemEditorFactory(CppInstancePtr @this, [MangleAs("class QItemEditorFactory *")] QItemEditorFactory value);
        }
        private struct _QItemDelegate {
        }
    }
}
