import { createRouter, createWebHistory } from "vue-router";
import AddView from "../views/AddView.vue";
import UploadView from "../views/UploadView.vue";
import ListView from "../views/ListView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "List",
      component: ListView,
    },
    {
      path: "/add-film",
      name: "add-film",
      component: AddView,
    },
    {
      path: "/upload-films",
      name: "upload-films",
      component: UploadView,
    },
  ],
});

export default router;
