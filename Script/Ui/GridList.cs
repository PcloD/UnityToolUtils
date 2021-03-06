﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.tool {
    public abstract class GridList<D, E> : MonoBehaviour where E : Component {

        private E template;
        protected List<E> rows = new List<E>();

        public abstract List<D> listData();

        internal abstract void setEmplty(E row);

        internal abstract void refleshTile(D d, E e);

        public void Awake() {
            template = GetComponentInChildren<E>();
            rows.Add(template);
        }

        public virtual void reflesh() {
            List<D> ds = listData();
            initTiles(ds);
            rows.ForEach(r => { setEmplty(r); });
            for (int i = 0; i < ds.Count; i++) {
                refleshTile(ds[i], rows[i]);
            }
        }

        private void initTiles(List<D> ds) {
            while (ds.Count > rows.Count) {
                createTile();
            }

        }

        private void createTile() {
            E nE = Instantiate(template, transform, false);
            rows.Add(nE);
        }
    }
}
