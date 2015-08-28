package springweb.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.servlet.ModelAndView;
import springweb.entities.User;
import springweb.services.UserService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/admin")
public class UserController {

    @Autowired
    private UserService userService;

    public UserService getUserService() {
        return userService;
    }

    public void setUserService(UserService userService) {
        this.userService = userService;
    }

    @RequestMapping(value = "/user", method = RequestMethod.GET)
    public ModelAndView index(ModelMap model) {
        User user = userService.findByUserName("admin");
        ModelAndView mv = new ModelAndView("admin/user/list");
        mv.addObject("user", user);
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.GET)
    public ModelAndView add(ModelMap model) {
        ModelAndView mv = new ModelAndView("admin/user/add");
        return mv;
    }

    @RequestMapping(value = "/user/add", method = RequestMethod.POST)
    public void save(ModelMap model) {

    }
}
