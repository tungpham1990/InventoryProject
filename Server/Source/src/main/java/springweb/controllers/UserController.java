package springweb.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;
import springweb.entities.UserInfo;
import springweb.services.UserInfoService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/admin")
public class UserController {

    @Autowired
    private UserInfoService userInfoService;

    public UserInfoService getUserService() {
        return userInfoService;
    }

    public void setUserService(UserInfoService userService) {
        this.userInfoService = userService;
    }

    @RequestMapping(value = "/json", method = RequestMethod.GET, produces={"application/json"})
    public @ResponseBody UserInfo index(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
        return user;
    }
    
    
    @RequestMapping(value = "/user", method = RequestMethod.GET)
    public ModelAndView json(ModelMap model) {
        UserInfo user = userInfoService.findByUserName("admin");
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
